# com0com 가상 시리얼 포트 드라이버 설치

## 1. CMD 관리자 권한 실행에서 테스트서명 활성화
```cmd
bcdedit.exe -set TESTSIGNING ON
```

## 2. 테스트서명 활성화 확인
```cmd
bcdedit /enum | findstr /i testsigning
```

## 3. com0com에서 가상 시리얼 포트 드라이버 다운로드

**다운로드 링크:**
https://sourceforge.net/projects/com0com/files/com0com/3.0.0.0/com0com-3.0.0.0-i386-and-x64-signed.zip/download
com0com-3.0.0.0-i386-and-x64-signed.zip


## 4. 설치 후 확인

설치 이후 **장치관리자** > **포트**에서 실제 활성화된 가상 시리얼 포트 확인하기
(com0com 생성된 것 확인하기)
