# Projeto de teste de back-end com ORM e MySql

## Pacotes utilizados

- ORM
- Migrations
- Conexão ao mysql
- Ferramentas EF Core
- Gerenciadores de Secrets

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 9.0.0
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.Extensions.Configuration --version 9.0.0
dotnet add package Microsoft.Extensions.Configuration.UserSecrets --version 9.0.0
```

## Secrets utilizados

- DbPort
- DbName
- DbUser
- DbPassword

```bash
dotnet user-secrets init
dotnet user-secrets set "DbPort" "SuaPorta"
dotnet user-secrets set "DbName" "SeuNomeDeBanco"
dotnet user-secrets set "DbUser" "SeuUser"
dotnet user-secrets set "DbPassword" "SuaSenhaSegura"
```

## Criação do Banco mysql

```sql
Create Database SeuNomeDeBanco;
```

## Controle da Migration

- Criar Migração

```bash
dotnet ef migrations add MigrationVersionName
```

- Deletar Migrações não salvas

```bash
dotnet ef migrations remove
```

- Salvar Migrações

```bash
dotnet ef database update
```
