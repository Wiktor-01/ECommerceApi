Projekt zawiera automatyczny proces CI z użyciem GitHub Actions:

- **Kiedy?** Przy każdym `push` do gałęzi `main`
- **Co robi?**
  - Pobiera kod
  - Instaluje .NET
  - Przywraca zależności
  - Buduje aplikację

Plik workflow: `.github/workflows/dotnet.yml`
