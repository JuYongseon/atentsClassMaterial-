Shader "Custom/_9_13_SurfaceBasic"
{
    Properties//외부에 공개되는 변수
    {
        _Color("Color", Color) = (1,1,1,1)
        _Alpha("Alpha", Range(0,2)) = 1
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader//실질적으로 프로그램이 돌아가는 위치
    {
        Tags { "RenderType"="Opaque" "Queue"="Transparent"}
        LOD 200
        CGPROGRAM//시작을 알리는 프로그램
        //Standard 조명, fullforwardshadows 그림자 설정
        #pragma surface surf Standard alpha:fade //fullforwardshadows 모든 조건의 그림자(프로그램 원본에 있는 데 알파로 바꿔서 코드 작성중)
        #pragma target 3.0
        //그래픽 카드의 입력
        struct Input //그래픽카드에 전달하는 값 ****무조건 존재 해야함*****
        {
            float2 uv_MainTex;//텍스처에 전달되는 uv좌표
        };
        //프로퍼티를 사용하기 위해서는 선언을 해줘야한다.
        fixed4 _Color;//변수 선언하는 곳    fixed4 실수보다 더 작은 변수
        fixed _Alpha;
        sampler2D _MainTex;

        UNITY_INSTANCING_BUFFER_START(Props)
        UNITY_INSTANCING_BUFFER_END(Props)
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            //Albedo란 조명을 반영한 RGB
            //o.Albedo = float4(0,0,0,0) //연산 결과를 o의 멤버에 채워 준다.
            //o.Albedo = _Color;
            
            o.Emission = fixed3(0.3,0.2,0.7) + fixed3(0.4, 0.9, 0.4);

            o.Alpha = _Alpha;
        }
        ENDCG//끝을 알리는 프로그램
    }
    FallBack "Diffuse"
}
