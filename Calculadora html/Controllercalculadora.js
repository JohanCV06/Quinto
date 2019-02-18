exports.Suma = function(req, res){
    res.json(parseInt(req.body.numero1) + parseInt(req.body.numero2)); //devuelve todas las Personas en JSON
}

exports.Resta = function(req, res){
    res.json(parseInt(req.body.numero1) - parseInt(req.body.numero2)); //devuelve todas las Personas en JSON
}

exports.Division = function(req, res){
    res.json(parseInt(req.body.numero1) / parseInt(req.body.numero2)); //devuelve todas las Personas en JSON
}

exports.Multiplicacion = function(req, res){
    res.json(parseInt(req.body.numero1) * parseInt(req.body.numero2)); //devuelve todas las Personas en JSON
}