// Função para gerar ID aleatório com 10 dígitos
function generateRandomId() {
    let result = '';
    for (let i = 0; i < 10; i++) {
      result += Math.floor(Math.random() * 10);
    }
    return result;
  }
  
  // Seleciona o botão "Gerar ID"
  const btnGeraId = document.querySelector('#gera_id');
  const userIds = document.getElementsByName('cadastro_id');
  
  // Adiciona um listener de evento "click" no botão "Gerar ID"
  btnGeraId.addEventListener('click', (event) => {
    event.preventDefault();
    for (let i = 0; i < userIds.length; i++) {
      userIds[i].value = generateRandomId();
    }
  });
  


  const btnAdicionarUsuario = document.getElementById("addUser");

btnAdicionarUsuario.addEventListener("click", (event) => {
  event.preventDefault();

  const form = document.querySelector("#com-cadastro");
  const inputs = form.querySelectorAll("input, select");

  inputs.forEach((input) => {
    console.log(input.name + ": " + input.value);
  });
});