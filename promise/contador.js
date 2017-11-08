function funcionA () {
  return new Promise((resolve, reject) => {
    var usuario = {
      'nombre': 'james',
      'apellido': 'milner'
    };
    resolve(usuario);
  });
}

var el = document.getElementById('content');

funcionA()
  .then(function(usr){
    console.log(usr);
    el.innerHTML = usr.nombre;
  });