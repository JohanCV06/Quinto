var Controller = require ('./controllercalculadora');
var cors = require('cors');

module.exports = function(app){



app.use(cors());
//Devolver todas las personas
app.post('/api/sumar', Controller.Suma);


app.post('/api/restar', Controller.Resta);

app.post('/api/dividir', Controller.Division);
app.post('/api/multiplicar', Controller.Multiplicacion);

};