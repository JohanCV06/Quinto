        
function agrecero(){
            document.getElementById("result").innerHTML +=0;
        }
        function agreuno(){
            document.getElementById("result").innerHTML +=1;
        }
        function agredos(){
            document.getElementById("result").innerHTML +=2;
        }
        function agretres(){
            document.getElementById("result").innerHTML +=3;
        }
        function agrecuatro(){
            document.getElementById("result").innerHTML +=4;
        }
        function agrecinco(){
            document.getElementById("result").innerHTML +=5;
        }
        function agreseis(){
            document.getElementById("result").innerHTML +=6;
        }
        function agresiete(){
            document.getElementById("result").innerHTML +=7;
        }
        function agreocho(){
            document.getElementById("result").innerHTML +=8;
        }
        function agrenueve(){
            document.getElementById("result").innerHTML +=9;
        }
        var numero1=0;
        var numero2=0;
        var operacionsel = 0;
        function operacion(oper)
        {
            switch(oper)

                {
                        
                    case "suma":
                        operacionsel=1;
                        break;
                    case "resta":
                         operacionsel=2;
                        break;
                        case "por":
                         operacionsel=3;
                        break;
                    case "div":
                         operacionsel=4;
                        break;
                    default:
                        break;
                        
                }
            
            numero1=document.getElementById("result").innerHTML;
            document.getElementById("result").innerHTML="";
            
        }
        function resultado()
        {
            switch(operacionsel)

                {
                        
                    case 1:
                       numero2=document.getElementById("result").innerHTML;
            document.getElementById("result").innerHTML="";
            
            equals();
                        break;
                    case 2:
                           numero2=document.getElementById("result").innerHTML;
            document.getElementById("result").innerHTML="";
            
            equals1();
                        break;
                        case 3:
                           numero2=document.getElementById("result").innerHTML;
            document.getElementById("result").innerHTML="";
            
            equals2();
                        break;
                    case 4:
                         numero2=document.getElementById("result").innerHTML;
            document.getElementById("result").innerHTML="";
            
            equals3();  
                        break;
                    default:
                        break;
                        
                }
            
          
            
        }
    function equals()
        {
            var formulario = new Object();// objeto que recibe el controller del backend
            formulario.numero1 = numero1; // campos que lee el controlador
            formulario.numero2 = numero2;
            
            $.ajax({
                url: 'https://localhost/api/suma', //direccion al que se hace el llamado
                type: 'POST', // tipo de datos
                dataType: 'json',
                data:formulario, //objeto que se esta pasando al servidor
                succes: function (data, textStatus, xhr){//en caso de obtener una respuesta afirmativa del servidor
                    document.getElementById("result").innerHTML = data;
                    //muestra el resultado en el campo de texto de la calculadora
                },
                error: function (xhr, textStatus, errorThrown){
                    alert(xhr);
                }
                });
        }
            function equals1()
        {
            var formulario = new Object();// objeto que recibe el controller del backend
            formulario.numero1 = numero1 // campos que lee el controlador
            formulario.numero2 = numero2;
            
            $.ajax({
                url: 'https://localhost/api/resta', //direccion al que se hace el llamado
                type: 'POST', // tipo de datos
                dataType: 'json',
                data:formulario, //objeto que se esta pasando al servidor
                succes: function (data, textStatus, xhr){//en caso de obtener una respuesta afirmativa del servidor
                    document.getElementById("result").innerHTML = data;
                    //muestra el resultado en el campo de texto de la calculadora
                },
                error: function (xhr, textStatus, errorThrown){
                    alert(xhr);
                }
                });
        }
            function equals2()
        {
            var formulario = new Object();// objeto que recibe el controller del backend
            formulario.numero1 = numero1 // campos que lee el controlador
            formulario.numero2 = numero2;
            
            $.ajax({
                url: 'https://localhost/api/multiplicacion', //direccion al que se hace el llamado
                type: 'POST', // tipo de datos
                dataType: 'json',
                data:formulario, //objeto que se esta pasando al servidor
                succes: function (data, textStatus, xhr){//en caso de obtener una respuesta afirmativa del servidor
                   document.getElementById("result").innerHTML = data;
                    //muestra el resultado en el campo de texto de la calculadora
                },
                error: function (xhr, textStatus, errorThrown){
                    alert(xhr);
                }
                });
        }
            function equals3()
        {
            var formulario = new Object();// objeto que recibe el controller del backend
            formulario.numero1 = numero1 // campos que lee el controlador
            formulario.numero2 = numero2;
            
            $.ajax({
                url: 'https://localhost/api/division', //direccion al que se hace el llamado
                type: 'POST', // tipo de datos
                dataType: 'json',
                data:formulario, //objeto que se esta pasando al servidor
                succes: function (data, textStatus, xhr){//en caso de obtener una respuesta afirmativa del servidor
                    document.getElementById("result").innerHTML = data;
                    //muestra el resultado en el campo de texto de la calculadora
                },
                error: function (xhr, textStatus, errorThrown){
                    alert(xhr);
                }
                });  
        }
            