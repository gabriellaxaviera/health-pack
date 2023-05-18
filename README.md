# health-calc-pack-dotnet

### Curso de Pós-Graduação em Engenharia de Software da PUC-MG

### Projeto apresentado à disciplina _Projeto Integrado em Engenharia de Software_

# Proposta Projeto
Uma biblioteca que disponibiliza uma interface para cálculo do IMC e macronutrientes com base nos dados informados pelo usuário. Foi construída utilizando C# e distribuída no NuGet.

# Funcionalidades

<img src='nutrition-calc-diagram.jpg' alt='Diagrama'>

# IMC

IMC = Peso (em kg) dividido pela altura (em centímetros) ao quadrado ( peso/altura²)

Classifição:

- Menor que 18.5 - Abaixo do peso
- Entre 18.5 e 24.9 - Peso normal
- Entre 25.0 e 29.9 - Pré-obesidade
- Entre 30.0 e 34.9 - Obesidade Grau 1
- Entre 35.0 e 39.9 - Obesidade Grau 2
- Acima de 40 - Obesidade Grau 3

# Macronutrientes

Os macronutrientes serão calculados baseados nos seguintes parâmetros e regras:

- Sexo

  - Reduzir em 20% os resultados para sexo feminino

- Peso em Kg

  - O peso informado deve ser >= 35 kg

- Nível de Atividade:

  - Sedentário
  - Moderadamente Ativo
  - Bastante Ativo
  - Extremamente Ativo

- Objetivo:

  - Bulking (Aumento de Peso):

    - Proteína: 2g por Kg
    - Gordura: 2g por Kg
    - Carboidrato:
      - 4g por Kg (metabolismo lento e rotina mais cedentária)
      - 7g por Kg (metabolismo acelerado e rotina de exercícios)

  - Cutting (Perda de Peso)

    - Proteína: 2g por Kg
    - Gordura: 1g por Kg
    - Carboidrato: 2g por Kg

  - Manter o Peso

    - Proteína: 2g por Kg
    - Gordura: 1g por Kg
    - Carboidrato: 5g por Kg

# Tecnologias Utilizadas

- Framework

  - [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.403-windows-x64-installer)

- Testing

  - [XUnit.net](https://xunit.net/)

- Distribuição

  - [NuGet](https://www.nuget.org/)

# Como utilizar

Para instalar a [biblioteca](https://www.nuget.org/packages/health-calc-pack-dotnet-mldzs/1.0.0) em seus projetos, basta seguir o tutorial do link.

Após a instação:

Criar uma nova instância das classes que darão acesso as funções:

- IMC
  - Calc (realiza o cálculo do IMC)
  - GetIMCCategory (Retorna a categoria de peso, dado um IMC)

- Macronutriente
  - Calc (realiza o cálculo do consumo diário de macronutrientes)
