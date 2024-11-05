# User Story: Visualizar Dados da Conta Bancária

<strong>Como um</strong>  cliente bancário,
<strong>eu quero</strong> acessar e visualizar meus dados bancários, incluindo saldo, informações pessoais e histórico de transações,
<strong>para que</strong> eu possa acompanhar meu saldo atual e verificar minhas transações recentes.

<strong> Critérios de Aceitação </strong> 

1. <strong> Exibir Saldo e Informações da Conta: </strong>
    * O sistema deve permitir que o cliente visualize o saldo da sua conta bancária, o número da conta e seu nome.
    * Apenas os dados necessários serão exibidos.
    * A exibição ocorrerá por meio de uma interface simples. O usuário irá solicitar a exibição de seus dados ou transações e informar o número de sua conta para tal.

2. <strong> Listagem de Transações: </strong>
    * O sistema deve exibir um histórico das últimas 10 transações da conta do cliente, incluindo a data, valor e tipo de   transação (exemplo: depósito, saque).   
    * Cada transação deve estar organizada em ordem cronológica.

3. <strong> Transmissão de Dados via DTO: </strong>
    * Dados entre o back-end e o front-end devem ser transferidos de forma segura e desacoplada, usando uma classe ContaDTO.
    * O ContaDTO deve incluir apenas as informações essenciais: nome do cliente, número da conta e saldo atual. 

<strong> Notas Técnicas </strong>
- Implementar a transferência de dados entre camadas usando o ContaDTO, que evita o acoplamento direto com a camada de dados e facilita a manutenção e expansão do sistema.
Faça uma reflexão sobre como o uso do DTO mantém o sistema organizado e explica os benefícios de separar as regras de negócio da funcionalidade.


<strong> Recursos </strong>
- GitHub Project Board: Cada grupo deve copiar o board especificado no GitHub do aluno host para organizar as tasks, criando cards e movendo-os conforme o progresso em colunas como To Do, In Progress, Tests, Review, Done.

## Definição de Completo
- Todas as tasks foram organizadas no board e implementadas.
- O cliente consegue visualizar o saldo, histórico de transações e realizar operações respeitando as regras de negócio. 
- Todos os dados estão sendo transferidos através do ContaDTO, com a interface organizada conforme os critérios de aceitação.

 