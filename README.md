# ledDEMO
Código integrando C# e Arduino para acender um led feito para o Minicurso de C#

Segue um pequeno passo a passo:

1 - Criar interface com 2 Botões (conectar e ligar led) e uma combobox para as portas COM
2 - Adicionar um timer e settar seu tempo para 1000 ms
3 - Em Form1() adicionar timer.Enabled = true;
4 - Adicionar o evento timer_Tick
	4.1  Código a ser adicionado dentro do evento:
	```C#
	        foreach (var port in SerialPort.GetPortNames())
            {
        	    if (!comPortsCombobox.Items.Contains(port)) //mesma coisa que comPortsCombobox.Items.Contains(port) == false 
                {
                    comPortsCombobox.Items.Add(port);
                }
            }
	    ```
5 - Criar uma porta serial como variável global
	SerialPort serialport = new SerialPort();
	5.1 Criar uma constante para o baudrate
	const int baudrate = 9600;

6 - Adicionar evento de click do botão arduinoConnectButton
	6.1 if(!serialport.IsOpen) para verificar se a porta está fechada
	bloco try:
	try
    {
        string portName = comPortsCombobox.Text;
        serialport = new SerialPort(portName, baudRate);
        serialport.Open();
        MessageBox.Show("SUCESSO", "Arduino conectado!");
        timer.Stop();
    }
    6.2 bloco catch
    catch(IOException exception)
    {
        MessageBox.Show("ERRO", exception.Message);
    }

7 - Em Form1() => ledButton.Enabled = false;
	para desabilitar o botão
8 - No evento de conectar o arduino adicionar
	ledButton.Enabled = true;
	Assim o botão de enviar informação só será ativado quando a porta estiver conectada
9 - Criar evento ledButton_Click
10 - criar booleano global IsLedOn
11 - Código do evento de click:
	if (!IsLedOn)
    {
        serialport.Write("1");
        ledButton.Text = "DESLIGA LED";
        IsLedOn = true;
    }
    else if (IsLedOn)
    {
        serialport.Write("0");
        ledButton.Text = "LIGA LED";
        IsLedOn = false;
    }

12 - Agora é só tirar do congelador e TÁ PRONTO O SORVETINHO

Avisos gerais:
- O baudrate neste caso é fixo, mas caso queira, você pode criar outra textbox com valores de baudrate diferentes para que o usuário selecione.
- É possível alterar o tempo de tick do timer por código
  timer.Interval(tempo em ms)
- Este código NÃO apresenta lógica para desconectar a porta COM com um botão





