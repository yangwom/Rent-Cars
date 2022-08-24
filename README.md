
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
