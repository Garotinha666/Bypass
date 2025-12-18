# Projeto de Estudo – Técnica de Bypass via Registro do Windows (C#)

## ⚠️ Aviso Legal Importante

Este projeto é disponibilizado **exclusivamente para fins educacionais, acadêmicos e de pesquisa em segurança da informação**.

O código demonstra uma técnica conhecida de:
- Manipulação do Registro do Windows
- Abuso de handlers do `ms-settings`
- Execução indireta de processos
- Bypass de mecanismos de proteção do sistema

⚠️ **O uso deste código em sistemas sem autorização explícita é ilegal e antiético.**

Os autores **não se responsabilizam** por qualquer dano, uso indevido ou violação legal decorrente da utilização deste material.

---

## 📌 Visão Geral do Projeto

Este projeto demonstra, em nível técnico, uma técnica de bypass baseada na modificação de chaves do Registro do Windows relacionadas ao manipulador `ms-settings`.

A técnica explora:
- Criação de chaves em `HKCU\Software\Classes`
- Redirecionamento de execução via `DelegateExecute`
- Abuso de binários confiáveis do Windows (LOLBins)
- Execução de código no contexto do usuário

Esse tipo de abordagem é frequentemente estudado em:
- Análise de malware
- Red Team
- Pesquisa de evasão de defesas
- Treinamento de Blue Team

---

## 🧠 Conceitos Técnicos Envolvidos

- **Windows Registry (HKCU)**
- **User Account Control (UAC)**
- **DelegateExecute**
- **ms-settings handler**
- **Process Injection indireta**
- **Living Off The Land Binaries (LOLBins)**

O código faz uso de binários legítimos do sistema operacional para acionar comportamentos não convencionais.

---

## 🛠️ Tecnologias Utilizadas

- Linguagem: **C#**
- Plataforma: **.NET Framework / .NET**
- Sistema Operacional: **Windows**

---

## 🖥️ Requisitos de Sistema (Teóricos)

- Windows 10 ou superior
- Ambiente .NET compatível
- Permissões de usuário padrão (não administrador)

> Observação: O comportamento depende da versão do Windows e das políticas de segurança ativas.

---

## 📁 Estrutura Lógica do Código

- Criação de chaves de registro sob `Software\Classes`
- Definição de comando padrão
- Uso da chave `DelegateExecute`
- Execução de binário legítimo do Windows
- Limpeza do Registro após execução

---

## 📚 Finalidade Educacional

Este repositório é indicado para:
- Estudo de técnicas de evasão
- Análise de comportamento ofensivo
- Desenvolvimento de contramedidas defensivas
- Pesquisa em segurança ofensiva e defensiva

**Nunca utilize este código fora de ambientes controlados**, como:
- Máquinas virtuais
- Laboratórios de teste
- Ambientes com autorização formal

---

## 🧑‍💻 Autor(es)

- Autor original do código conforme comentário interno
- README elaborado para fins educacionais

---

## 🛑 Aviso Final

Técnicas como esta são constantemente monitoradas e mitigadas por soluções de segurança modernas.

O entendimento dessas abordagens deve ser utilizado **exclusivamente para fortalecer sistemas defensivos**, nunca para exploração indevida.
