# Pomodoro (Windows Forms)

[![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.5.2-512BD4?logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-WinForms-239120?logo=c-sharp&logoColor=white)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Lisans: MIT](https://img.shields.io/badge/Lisans-MIT-green.svg)](./LICENSE)

## Neden Bu Proje?

Bu proje, odaklı çalışma ve planlı mola döngülerini basit bir masaüstü arayüzü ile yönetmek isteyen kullanıcılar için geliştirilmiş bir Pomodoro zamanlayıcısıdır; tekli sayaç ve 4 Pomodoro akışı gibi senaryoları destekleyerek dikkat dağınıklığını azaltmayı, sürdürülebilir çalışma ritmi kurmayı ve üretkenliği artırmayı hedefler.

## Mimari / Özellikler

- **WinForms tabanlı masaüstü uygulama** (`Form1`, `Form2`) ile hızlı kullanım.
- **Merkezi zamanlayıcı modeli** (`Sayac`) ile başlat/duraklat/sıfırla akışı.
- **Tekli mod ve 4 Pomodoro modu** arasında geçiş desteği.
- **Sesli bildirim akışı** (`Fonk.SesCal`) ile süre sonu uyarıları.
- **DevExpress bileşenleri** ile ilerleme çubuğu ve UI öğeleri.


## Hızlı Başlangıç

> Not: Proje **.NET Framework 4.5.2** ve **DevExpress 16.2** bağımlılığı nedeniyle Windows ortamında derlenmelidir.

```bash
git clone https://github.com/furkanisikay/Pomodoro.git
cd Pomodoro
msbuild Pomodoro.csproj /p:Configuration=Release
.\bin\Release\Pomodoro.exe
```

> Kendi fork'unuzu kullanıyorsanız `git clone` satırındaki URL'yi kendi depo adresinizle değiştirin.

## Ortam Kurulumu

1. Windows üzerinde Visual Studio (Desktop development with .NET) kurun.
2. **.NET Framework 4.5.2 Developer Pack** yüklü olmalı.
3. Projede kullanılan **DevExpress v16.2** bileşenlerinin sistemde erişilebilir olduğundan emin olun.
4. Derleme için `msbuild` komutunu Visual Studio Developer Command Prompt üzerinden çalıştırın.

## Katkı

Katkı süreci için bkz. [CONTRIBUTING.md](./CONTRIBUTING.md).

## Lisans

Bu proje [MIT Lisansı](./LICENSE) ile lisanslanmıştır.
