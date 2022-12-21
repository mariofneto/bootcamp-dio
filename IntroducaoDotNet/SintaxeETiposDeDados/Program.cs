using SintaxeETiposDeDados.Models.Animais;
using SintaxeETiposDeDados.Models;

var mario = new Pessoa("Mário", 21);
var odila = new Pessoa("Odila", 21);
var julia = new Pessoa("Júlia", 52);

mario.Apresentar();
odila.Apresentar();
julia.Apresentar();

Console.WriteLine("===========================");

var sol = new Cachorro("Sol", 2, mario);
var mel = new Gato("Mel", 1, odila);
var rukia = new Gato("Rukia", 3, julia);

sol.Apresentar();
mel.Apresentar();
rukia.Apresentar();