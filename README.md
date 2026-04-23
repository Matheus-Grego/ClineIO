# 📅 Clineio

Clineio é um sistema de **agendamento de consultas** desenvolvido para facilitar a organização de horários entre pacientes e profissionais de saúde, oferecendo uma experiência simples, rápida e eficiente.

---

## ✨ Funcionalidades

- 🗓️ Agendamento de consultas em tempo real  
- 👤 Cadastro de pacientes e profissionais  
- 🏥 Gestão de agendas por profissional  
- 🔔 Notificações de confirmação e lembrete de consultas  
- ❌ Cancelamento e remarcação de consultas  
- 📊 Painel administrativo  
- 🔐 Autenticação e controle de acesso (JWT)

---

## 🧱 Arquitetura

O sistema foi desenvolvido com separação de responsabilidades:

- **Frontend:** Interface do usuário (web/mobile)
- **Backend:** API com regras de negócio
- **Banco de dados:** Persistência de usuários, agendas e consultas
- **Autenticação:** Controle de acesso por perfis (paciente, profissional, admin)

---

## 🛠️ Tecnologias

- .NET (ASP.NET Core Web API)
- C#
- Entity Framework Core
- SQL Server / PostgreSQL
- JWT (Authentication)
- Swagger
- React / Angular (opcional no frontend)
- Docker (opcional)

---

## 🚀 Como executar o projeto

### 1. Clonar o repositório
```bash
git clone https://github.com/matheus-grego/clineio.git
cd clineio
