Shader "Custom/NewSurfaceShader"
{
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _CirclePosition ("Circle Position", Vector) = (0, 0, 0, 0)
        _CircleRadius ("Circle Radius", Range(0, 1)) = 0.5
    }
    
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200
        
        CGPROGRAM
        #pragma surface surf Lambert
        
        sampler2D _MainTex;
        float4 _CirclePosition;
        float _CircleRadius;
        
        struct Input {
            float2 uv_MainTex;
        };
        
        void surf (Input IN, inout SurfaceOutput o) {
            float2 circleCenter = _CirclePosition.xy;
            float2 circleUV = IN.uv_MainTex - circleCenter;
            float circleDistance = length(circleUV);
            
            if (circleDistance <= _CircleRadius) {
                o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
            }
            else {
                discard;
            }
        }
        ENDCG
    }
    FallBack "Diffuse"

}
