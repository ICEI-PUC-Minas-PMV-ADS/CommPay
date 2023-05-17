$(document).ready(function() {
        // Seletor para o input em questão (substitua pelo seu seletor correto)
        $('#Valor').maskMoney({
            prefix: 'R$ ', // Prefixo exibido antes do valor
            thousands: '.', // Separador de milhares
            decimal: ',', // Separador decimal
            precision: 2 // Quantidade de casas decimais
        });
  });
