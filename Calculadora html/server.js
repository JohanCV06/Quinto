//inicializacion
var express = require('express');
var app = express();
var port = process.env.PORT || 8080;

var BodyParser = require('body-parser')
app.configure(function(){
    app.use(express.static(__dirname + '/'));
    app.use(express.logger('dev'));
    app.use(express.bodyParser());
    app.use(express.methodOverride());
    // app.use(bodyParser.json({limit: '50mb'}));
    //app.use(bodyPArser.urlencoded({limit: '50mb', extended: true}));
});

//cargamos los endpoints
require('./Routes.js')(app);

//cogemos el puerto a escuchar
app.listen(port);
console.log('APP por el puerto '+ port);