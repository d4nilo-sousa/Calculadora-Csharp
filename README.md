# Calculadora C#
 Esta é uma simples calculadora desenvolvida em C# para realizar operações básicas.

 ## Instalação
Siga as etapas abaixo para clonar e executar o projeto:

1. Clone o repositório:
   ```bash
   git clone https://github.com/d4nilo-sousa/Calculadora-csharp.git
   
2. Abra o projeto no Visual Studio.

3. Compile e execute o projeto pressionando F5 ou clicando em Iniciar.

## Exemplo de Uso
Após iniciar a aplicação, você verá a interface da calculadora. Para realizar uma operação:

1. Digite um número clicando nos botões numéricos.
2. Selecione o operador desejado (adição, subtração, multiplicação, divisão, etc.).
3. Digite o segundo número.
4. Clique no botão "=" para exibir o resultado.
5. Para operações como raiz quadrada, porcentagem ou potência ao quadrado, clique no operador correspondente diretamente após digitar o número.


# Trechos do código:

### 1. Construtor e Variáveis Globais
```csharp
public partial class FrmCalculadora : Form
{
    //variáveis globais:
    double numero1 = 0, numero2 = 0;
    char operador;

    public FrmCalculadora()
    {
        InitializeComponent();
    }
}
``` 
Aqui, temos as variáveis globais numero1, numero2 e operador, que são usadas para armazenar os números da operação e o operador selecionado pelo usuário. O construtor FrmCalculadora() inicializa o formulário.

### 2. Adicionando números ao display
```csharp
private void AgregarNumero(object sender, EventArgs e)
{
    var boton = (Button)sender;

    if (txtResultado.Text == "0")
    {
        txtResultado.Text = "";
    }

    txtResultado.Text += boton.Text; 
}
```
Essa função captura o número clicado no botão da calculadora e o adiciona ao campo de texto txtResultado. Se o valor atual no display for 0, ele é substituído pelo número selecionado. Adicionei a função agregarNumero nas propriedades de cada botão dos números no efeito de Click

### 3. Seleção de operador e operações especiais
```csharp
private void ClickOperador(object sender, EventArgs e)
{
    var boton = (Button)sender;
    operador = Convert.ToChar(boton.Tag);

    numero1 = Convert.ToDouble(txtResultado.Text);
    
    if (operador == '√')
    {
        numero1 = Math.Sqrt(numero1);
        txtResultado.Text = numero1.ToString();
    }
    else if (operador == '²')
    {
        numero1 = Math.Pow(numero1,2);
        txtResultado.Text = numero1.ToString();
    }
    else if(operador == '%')
    {
        numero1 = numero1 / 100;
        txtResultado.Text = numero1.ToString();
    }
    else
    {
        txtResultado.Text = "0";
    }
}
```
Esse método identifica o operador selecionado (adição, subtração, multiplicação, divisão, etc.). Além disso, ele lida com operações especiais como a raiz quadrada,
potência ao quadrado e porcentagem

### 4. Limpar e apagar
```csharp
private void btnLimpar_Click(object sender, EventArgs e)
{
    numero1 = 0;
    numero2 = 0;
    operador = '\0';
    txtResultado.Text = "0";
}

private void btnApagar_Click(object sender, EventArgs e)
{
    if (txtResultado.Text.Length > 1) 
    {
        txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
    }
    else { txtResultado.Text = "0"; }
}
```
Esses métodos são responsáveis por limpar o campo de texto (resetando as variáveis) ou apagar o último dígito inserido

### Igualdade e cálculo final
```csharp 
private void btnIgual_Click(object sender, EventArgs e)
{
    numero2 = Convert.ToDouble(txtResultado.Text);

    if (operador == '+')
    {
        txtResultado.Text = (numero1 + numero2).ToString();
        numero1 = Convert.ToDouble(txtResultado.Text);
    }
    else if (operador == '-')
    {
        txtResultado.Text = (numero1 - numero2).ToString();
        numero1 = Convert.ToDouble(txtResultado.Text);
    }
    else if (operador == '*')
    {
        txtResultado.Text = (numero1 * numero2).ToString();
        numero1 = Convert.ToDouble(txtResultado.Text);
    }
    else if (operador == '/')
    {
        if(txtResultado.Text != "0")
        {
            txtResultado.Text = (numero1 / numero2).ToString();
            numero1 = Convert.ToDouble(txtResultado.Text);
        }
        else
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Não é possível a divisão por ZERO";
        }
    }
}
```
Este método realiza o cálculo final com base no operador selecionado e nos dois números inseridos. Ele também lida com divisões por zero, exibindo uma mensagem de erro se isso ocorrer.



