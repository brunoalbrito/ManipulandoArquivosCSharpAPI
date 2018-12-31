$("#sendFile").click(function(){
    var formData = new FormData();
    var inputFile = $("#inputFile")[0];
    formData.append("file", inputFile.files[0])

    $.ajax({
        url: 'http://localhost:49829/api/data/receiveFile',
        data: formData,
        type: 'POST',
        enctype: 'multipart/form-data',
        dataType: 'json',
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