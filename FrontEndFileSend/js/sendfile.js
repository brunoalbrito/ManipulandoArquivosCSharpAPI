$("#sendFile").click(function(){
    var formData = new FormData();
    var file = $("#inputFile")[0];
    $.ajax({
        url: 'http://localhost:49829/api/data/receiveFile',
        data: formData,
        type: 'POST',
        contentType: false,
        processData: false,
        success:function(data){
            alert("Ocorreu com sucesso")
        },
        error: function(){
            alert("Ocorreu uma falha ao inserir")
        }
    })  
});