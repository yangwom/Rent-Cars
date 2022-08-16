# Boas-vindas ao repositório do projeto Aluguel de Carros

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-rent-cars.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-projec-rent-cars`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project-rent-cars`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project-rent-cars`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project-rent-cars/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project-rent-cars/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/RentCars` ou de seus testes `src/RentCars.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

A empresa do coração em que você trabalha está desenvolvendo um sistema para controlar o aluguel de carros, e você foi o primeiro contratado para iniciar o desenvolvimento do sistema.

O `Rent Cars` está dividido em partes orgainzadas. Em `Model` você vai encontrar as classes bases que devem seguir a seguinte hierarquia:

- `Vehicle.cs` descreve uma classe **abstrata** base para os veículos.
  - `Car.cs` descreve uma classe derivada para **carros**.
  - `Truck.cs` descreve uma classe derivada para **caminhões**.
  - `Motorcycle.cs` descreve uma classe derivada para **motos**.
 
- `Person.cs` descreve uma classe **abstrata** base para as pessoas clientes do sistema.
  - `PhysicalPerson.cs` descreve uma classe derivada para **pessoas físicas**.
  - `LegalPerson.cs` descreve uma classe derivada para **pessoas jurídicas**.

- `Rent.cs` descreve a classe para um aluguel entre uma **pessoa** e um **veículo**.

## 1 - Criar uma `Struct` para as **Cores** no namespace RentCars.Types
`Crie sua lógica em src/RentCars/Types/Structs/Color.cs`
<details>
  <summary>A struct deve conter o campo <code>Name</code> do tipo <code>string</code></summary><br />

O atributo deve ser público.
  
</details>

<details>
  <summary>A struct deve conter o campo <code>Hex</code> do tipo <code>string</code></summary><br />

O atributo deve ser público.
  
</details>

<details>
  <summary>Crie os testes para a struct</summary><br />

Crie o teste em `src/RentCars.Test/TestStruct.cs`.

Em `ColorShouldHaveNameAttribute` você deve verificar se a struct tem o atributo `Name` do tipo `string`.

Em `ColorShouldHaveHexAttribute` você deve verificar se a struct tem o atributo `Hex` do tipo `string`.
  
</details>

## 2 - Criar enum `BreakeType` no namespace RentCars.Types
`Crie sua lógica em src/RentCars/Types/Enums/BreakeType.cs`
<details>
  <summary>O enum deve conter o campo <code>Chamber</code> com valor 1</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Disc</code> com valor 2</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Drum</code> com valor 3</summary><br /> 
</details>

<details>
  <summary>Crie os testes para o Enum</summary><br />

Crie o teste em `src/RentCars.Test/TestEnums.cs`.

Em `BreakeTypeShouldHaveCorrectValues` você deve verificar se o enum tem os atributos com os valores corretos.
  
</details>

## 3 - Criar enum `TractionType` no namespace RentCars.Types
`Crie sua lógica em src/RentCars/Types/Enums/TractionType.cs`
<details>
  <summary>O enum deve conter o campo <code>FrontWheelDrive</code> com valor 0</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>RearWheelDrive</code> com valor 1</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>AllWheelDrive</code> com valor 2</summary><br /> 
</details>

<details>
  <summary>Crie os testes para o Enum</summary><br />

Crie o teste em `src/RentCars.Test/TestEnums.cs`.

Em `TractionTypeShouldHaveCorrectValues` você deve verificar se o enum tem os atributos com os valores corretos.
  
</details>

## 4 - Criar enum `FuelType` no namespace RentCars.Types
`Crie sua lógica em src/RentCars/Types/Enums/FuelType.cs`
<details>
  <summary>O enum deve conter o campo <code>Alcohol</code> com valor 10</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Gasoline</code> com valor 20</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Flex</code> com valor 30</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Diesel</code> com valor 40</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Electric</code> com valor 50</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Hybrid</code> com valor 60</summary><br /> 
</details>

<details>
  <summary>Crie os testes para o Enum</summary><br />

Crie o teste em `src/RentCars.Test/TestEnums.cs`.

Em `FuelTypeShouldHaveCorrectValues` você deve verificar se o enum tem os atributos com os valores corretos.
  
</details>

## 5 - Criar enum `RentStatus` no namespace RentCars.Types
`Crie sua lógica em src/RentCars/Types/Enums/FuelType.cs`
<details>
  <summary>O enum deve conter o campo <code>Confirmed</code> com valor 0</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Finished</code> com valor 1</summary><br /> 
</details>
<details>
  <summary>O enum deve conter o campo <code>Cancelled</code> com valor igual ao <code>Finished</code></summary><br /> 
</details>

<details>
  <summary>Crie os testes para o Enum</summary><br />

Crie o teste em `src/RentCars.Test/TestEnums.cs`.

Em `RentStatusShouldHaveCorrectValues` você deve verificar se o enum tem os atributos com os valores corretos.
  
</details>

## 6 - Criar o construtor de `Rent` seguindo as regras de negócio
`Crie sua lógica em src/RentCars/Types/Enums/FuelType.cs`
<details>
  <summary>O construtor deve receber uma instância de Vehicle, uma de Person e um valor inteiro com os dias alugados.</summary><br /> 

  Para calcular o atributo `Price` deve-se seguir a seguinte regra:
  - Para pessoas fisícas o preço deve ser o preço por dia do veículo * os dias alugados.
  - Para pessoas jurídicas o preço deve ser o preço por dia do veículo * os dias alugados com 10% de desconto.

  O status inicial deve ser `RentStatus.Confirmed`.

  O construtor deve alterar o atributo `IsRented` do veículo para true.
  O construtor deve alterar o atributo `Debit` da pessoa para o Preço calculado.
</details>

<details>
  <summary>Crie os testes para o Rent()</summary><br />

Crie o teste em `src/RentCars.Test/TestRent.cs`.

Em `TestCreateRent` você deve verificar se a classe Rent cria corretamente uma instância com as regras de negócio descritas.
  
</details>

## 7 - Implementar os métodos de `cancelar` e `finalizar` um aluguel.
`Crie sua lógica em src/RentCars/Types/Enums/FuelType.cs`
<details>
  <summary>O construtor deve receber uma instância de Vehicle, uma de Person e um valor inteiro com os dias alugados.</summary><br /> 

  Para calcular o atributo `Price` deve-se seguir a seguinte regra:
  - Para pessoas físicas o preço deve ser o preço por dia do veículo * os dias alugados.
  - Para pessoas jurídicas o preço deve ser o preço por dia do veículo * os dias alugados com 10% de desconto.

  O status inicial deve ser `RentStatus.Confirmed`.

  O construtor deve alterar o atributo `IsRented` do veículo para true.
  O construtor deve alterar o atributo `Debit` da pessoa para o Preço calculado.
</details>
