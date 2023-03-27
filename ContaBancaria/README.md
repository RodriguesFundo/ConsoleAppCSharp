<h1>Conta Bancária </h1>

Este projeto em C# consiste em um sistema de conta bancária, com funções como criar conta, depósito, levantamento e verificar saldo. 💸🏦



## Utilização

Ao iniciar o programa, o usuário é apresentado ao menu principal, com as seguintes opções:

1. Criar conta 📝
2. Depositar
3. Levantar
4. Saldo
5. Sair do sistema ❌

Para selecionar uma opção, basta digitar o número correspondente e pressionar Enter.

### Criar conta

Para criar uma conta, o usuário deve informar o nome completo, o número da conta e, opcionalmente, o valor do depósito inicial. Caso o usuário escolha fazer o depósito inicial, o valor deve ser maior que zero.

### Depositar

Ao escolher a opção de depósito, o usuário deve informar o valor que deseja depositar. O valor deve ser maior que zero. :moneybag:

### Levantar

Ao escolher a opção de levantamento, o usuário deve informar o valor que deseja sacar. Caso o valor seja maior que o saldo disponível na conta, a transação não será efetuada.

### Saldo

Ao escolher a opção de verificar saldo, o programa irá exibir o saldo disponível na conta. :chart_with_upwards_trend:

### Finalização

Ao escolher a opção de sair do sistema, o programa será encerrado.

## Funcionamento 🚧

A classe `ContaBanco` contém as informações da conta, como nome, número da conta e saldo. A classe também possui os métodos para criar conta, depositar, levantar e verificar saldo.

A classe `Program` é responsável por exibir o menu e processar as escolhas do usuário. Ao escolher uma opção, a classe chama o método correspondente da classe `ContaBanco`.

Caso ocorra algum erro durante a execução do programa, será exibida uma mensagem de erro na tela. :warning:
