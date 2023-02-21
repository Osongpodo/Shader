# Unity Shader
> Research the Shader and Shader Graph

## Shader
> 화면에 출력할 픽셀의 위치와 색상을 계산하는 함수
### 1. ShaderLab
* 고정파이프라인 셰이더 : fixed function shader
* 가볍고 하드웨어 호환성이 좋지만 기능이 부족하여 고급효과를 기대할 수 없다.
* 다른 셰이더문법과 호환이 되지않는다.

### 2. Surface Shader
* CG셰이더 코드를 사용한다.
* 기본적인 조명코드와 버텍스 셰이더의 복잡한 부분은 스크립트를 이용하여 자동으로 처리되고 있고, 픽셀 셰이더 부분만 간편하게 작성할 수도 있어서 편리하다.
* 최적화에는 무리가 있고, 일정 수준 이상의 고급 기법을 구현하기엔 어렵다.
* 빛과 그림자에 영향을 받는 셰이더이다.

### 3. Vertex & Fragment Shader
* CG 셰이더코드 사용한다.
* 자동으로 처리해주는 부분이 별로 없어서 제대로된 CG 셰이더 방식으로 버텍스의 좌표변환부터 제대로 처리해야 작동한다.
* 최적화와 고급기법을 표현할 때 좋다.

### 형식
* shader는 properties와 Subshader로 구성
* properties는 속성값으로 다양한 종류의 파라미터를 넣을 수 있고 이름과 display이름과 값을 입력할수있다(숫자, 색상, 벡터, 텍스처 등을 추가할수있다)
* name (”display name” , Color) = (num,num,num,num)
* subshader 에 pass를 추가하고 그 내부에 material과 lighting을 추가
* pass는 물체를 그릴 때 gpu에게 넘겨줄 작업을 기술하는 곳(pass가 한개 이상이면 멀티패스라고 하며 하나의 물체를 두번에 걸쳐 그리게 됨)
* material은 물체의 재질을 결정, diffuse는 물체의 고유색상을 의미

## Shader Graph
> 직관적으로 셰이더를 제작하고, 사용자의 동작에 반응하는 애니메이션 효과와 인터랙티브 효과를 생성할 수 있다.   

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/29e106a4-f351-45fd-8fcb-dee95b54199f/Untitled.png)
