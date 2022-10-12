Shader "Custom/_9_13_SurfaceBasic"
{
    Properties//�ܺο� �����Ǵ� ����
    {
        _Color("Color", Color) = (1,1,1,1)
        _Alpha("Alpha", Range(0,2)) = 1
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader//���������� ���α׷��� ���ư��� ��ġ
    {
        Tags { "RenderType"="Opaque" "Queue"="Transparent"}
        LOD 200
        CGPROGRAM//������ �˸��� ���α׷�
        //Standard ����, fullforwardshadows �׸��� ����
        #pragma surface surf Standard alpha:fade //fullforwardshadows ��� ������ �׸���(���α׷� ������ �ִ� �� ���ķ� �ٲ㼭 �ڵ� �ۼ���)
        #pragma target 3.0
        //�׷��� ī���� �Է�
        struct Input //�׷���ī�忡 �����ϴ� �� ****������ ���� �ؾ���*****
        {
            float2 uv_MainTex;//�ؽ�ó�� ���޵Ǵ� uv��ǥ
        };
        //������Ƽ�� ����ϱ� ���ؼ��� ������ ������Ѵ�.
        fixed4 _Color;//���� �����ϴ� ��    fixed4 �Ǽ����� �� ���� ����
        fixed _Alpha;
        sampler2D _MainTex;

        UNITY_INSTANCING_BUFFER_START(Props)
        UNITY_INSTANCING_BUFFER_END(Props)
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            //Albedo�� ������ �ݿ��� RGB
            //o.Albedo = float4(0,0,0,0) //���� ����� o�� ����� ä�� �ش�.
            //o.Albedo = _Color;
            
            o.Emission = fixed3(0.3,0.2,0.7) + fixed3(0.4, 0.9, 0.4);

            o.Alpha = _Alpha;
        }
        ENDCG//���� �˸��� ���α׷�
    }
    FallBack "Diffuse"
}
