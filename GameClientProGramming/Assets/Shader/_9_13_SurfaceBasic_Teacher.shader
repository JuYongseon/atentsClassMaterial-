Shader "Custom_/_9_13_SurfaceBasic_________"    // 셰이더 이름
{
    Properties
    {
        _Color ("Color____CCC__", Color) = (1,1,1,1)
        _Alpha("Alpha", Range(0,1)) = 1
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent"}
        LOD 200
        CGPROGRAM
        #pragma surface surf Standard alpha:fade
        #pragma target 3.0
        struct Input
        {
            float2 uv_MainTex;
        };
        fixed4 _Color;
        fixed _Alpha;
        sampler2D _MainTex;

        UNITY_INSTANCING_BUFFER_START(Props)
        UNITY_INSTANCING_BUFFER_END(Props)
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo란 조명을 반영한 RGB
            //o.Albedo = float3(1,1,0); // 연산 결과를 o의 멤버에 채워 준다.
            //o.Albedo = _Color;
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            //o.Emission = fixed3(0,0,1); 
            o.Alpha = _Alpha;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
