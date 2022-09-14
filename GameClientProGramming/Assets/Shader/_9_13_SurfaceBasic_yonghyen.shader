Shader "Custom/_9_13_SurfaceBasic_shader______"
{
    Properties
    {
        _Color("Color___CCC", Color) = (0,1,0,0)
        _Alpha("Alpha", Range(0,1)) = 0 //실 사용 변수는 실수로 레인지형 변수는 일반적으로 half 자료형으로 사용(fixd도 가능)
    }
        
    SubShader //실질적인 부분
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}
        LOD 200
        CGPROGRAM // 프로그램 시작
        // Physically based Standard lighting model, and enable shadows on all light types
        //#pragma surface surf Standard fullforwardshadows
        // Standard = 조명 
        // fullforwardshadows 그림자
        
        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma surface surf Standard alpha : fade
        #pragma target 3.0

        struct Input
        {
            float2 uv_MainTex; // 그래픽 카드에 전달되는 입력 텍스쳐의 uv좌표 / float2는 실수 2개
        };
        fixed4 _Color;//프로퍼티를 사용하기 위한 선언 (연산하기 위해서는 선언을 해야한다)
        fixed  _Alpha;
        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)
        void surf (Input IN, inout SurfaceOutputStandard o)// 여기서 실질적인 연산 
        {   // Input In :   
            //SurfaceOutputStandard  여기에 값을 채워주면 최종적인RPG가 결정
            // surf 함수는 RGB 결정 함수
            // Albedo comes from a texture tinted by color
            // Albedo란 조명을 반영한 RGB
            //o.Albedo = float3(0,0,0);// 연산결과를 o의 멤버에 채워 준다.
            // o.Albedo = _Color;
            // Emission은 음영에 영향을 받지 않음

            o.Emission = fixed3(0, 0, 1);
            //_Alpha = 1;
            o.Alpha = _Alpha;
        }
        ENDCG // 프로그램 끝
    }
    FallBack "Diffuse"
            
}
