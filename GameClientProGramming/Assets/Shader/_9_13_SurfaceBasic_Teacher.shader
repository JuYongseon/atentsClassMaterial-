Shader "Custom_/_9_13_SurfaceBasic_________"    // ���̴� �̸�
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
            // Albedo�� ������ �ݿ��� RGB
            //o.Albedo = float3(1,1,0); // ���� ����� o�� ����� ä�� �ش�.
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
