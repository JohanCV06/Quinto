//Para el calendario
var winHeight = $(window).height();
var height = ( winHeight * 16.6666 ) / 100;
var lineHeight = height + "px";
$("li").css("line-height", lineHeight);
$("li").css("height", height);
var objeto = new Object();//Aca Definimos las variables de objetos
var op = 'listarparamovil';
var mes = 6;//variable de mes y anio que se utilizaran para saber en que anio estamos en el ajax de mas abajo
var anio =2018;
mesactual=" ";
var i = 0;//variable de loops



function ajax(){//este Ajax se usa para establecer parametros tipicos de Node.JS
    var data="";
    var objeto = new Object();
    objeto.op = op;
    objeto.mes = mes;//Establecemos el valor de los objetos con el valor de las variables de arriba
    objeto.anno =anio;
    $.ajax({
        url: 'http://teatrotico.com/api/Calendario',//Esta API nos la da TEATROTICO.com
        type: 'POST',
        dataType: 'json',
        data: objeto,
        success: function (datad, textStatus, xhr) {//En Caso de que el POST del Ajax sea Correcto elige un mes del objeto .mes y asi sabe en cual mes de la API de TeatroTico buscar eventos
            EscogerMes(mes);
            document.getElementById("mes").innerHTML = mesactual;
            LlenarDias(mes);//Esta Funcion es la que asigna los dias del 1 al 30 o al 31 con el parametro mes, el cual define la cantidad de dias
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);//error que lanza el Object Object en caso de error en la base de datos
        }
    });
}
function EscogerMes(num){//esta es la funcion que escoge el mes con el parametro num, dependiendo del numero de mes se coloca el mes ubicado, empezamos con el 6, por lo que lanzara Junio
    switch(num){
            case 1:
            mesactual = " Enero ";    
            break;
                    case 2:
            mesactual = " Febrero ";
            break;
                    case 3:
            mesactual = " Marzo ";
            break;
                    case 4:
            mesactual = " Abril ";
            break;
                    case 5:
            mesactual = " Mayo ";
            break;
                    case 6:
            mesactual = " Junio ";
            break;
                    case 7:
            mesactual = " Julio ";
            break;
                    case 8:
            mesactual = " Agosto ";
            break;
                    case 9:
            mesactual = " Setiembre ";
            break;
                    case 10:
            mesactual = " Octubre ";
            break;
                    case 11:
            mesactual = " Noviembre ";
            break;
                    case 12:
            mesactual = " Diciembre ";
            break;
                    default:
            mesactual ="";
            break;
            
            
            
    }
}
function LlenarDias(num){//esta es la funcion de llenar las fechas, la cual llena la cantidad de dia dependiendo del numero de mes
    document.getElementById("calendario").innerHTML = " ";
    if(num==1 || num==3 || num==5 || num==7 || num==8 || num==10 || num==12){
        for(i=1; i <= 31; i++){
            document.getElementById("calendario").innerHTML += "<li onclick='paracalendario("+i+")'>"+i+"</li>"
        }
    }
        if(num==4 || num==6 || num==9 || num==11){
        for(i=1; i <= 30; i++){
            document.getElementById("calendario").innerHTML += "<li onclick='paracalendario("+i+")'>"+i+"</li>"
        }
    }
        if(num==2){
        for(i=1; i <= 28; i++){
            document.getElementById("calendario").innerHTML += "<li onclick='paracalendario("+i+")'>"+i+"</li>"
        }
    }
    
}
function paracalendario(num){//esta es la funcion de PopUp que Con un POST lee los datos recibidos de la API con datos tipo JSON e imprime los resultados en un Alert
    var objeto = new Object();
    objeto.op = op;
    objeto.mes = mes;
    objeto.anno = anio;
    $.ajax({
        url: 'http://teatrotico.com/api/Calendario',
        type: 'POST',
        dataType: 'json',
        data: objeto,
        success: function (datad, textStatus, xhr) {
        for(i=0; i < datad.length; i++){
        if (num == datad[i].DIA){
        alert("Tipo de obra "+datad[i].EVENTO.DESCRIPCION + " Obra " + datad[i].EVENTO.NOMBRE + " Empieza a las " + datad[i].NUMERO_HORA_INICIA+" : "+datad[i].NUMERO_MINUTO_INICIA + " Termina a las " + datad[i].NUMERO_HORA_FIN + " : " + datad[i].NUMERO_MINUTO_FIN)
        }
        }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }
    });
}
function adelante(){//esta funcion añade un numero al mes, como los meses son numeros automaticamente se cambia el mes y los dias dependiendo del mes en que se encuentre, y llama a la funcion AJAX para volver a empezar y que se actualice el calendario
    mes += 1;
    ajax();
}
function atras(){//esta funcion quita un numero al mes, como los meses son numeros automaticamente se cambia el mes y los dias dependiendo del mes en que se encuentre, y llama a la funcion AJAX para volver a empezar y que se actualice el calendario
    mes -= 1;
    ajax();
}

