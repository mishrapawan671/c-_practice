$(document).ready(()=> {
    $("#LoginBtn").prop('disabled', true);
    $("#spinner").prop('hide', true);
});



function btnClick() {
    
    $.ajax({
        type: "POST",
        url: "http://localhost:63094/Demo/validate",
        data: { "uid": $('#userId').val() },
        success: (function (res)
        {
            console.log(res);
           

            if(res.iSvalid)
                {
                $("#LoginBtn").prop('disabled', false);
                $("#LoginBtn").removeClass('btn btn-warning');

                $("#LoginBtn").addClass('btn btn-success');
                    $("#message").text("Valid UserId");
                    $("#userId").prop('readonly', true);
                    $("#password").prop("readonly", true);
                }
                else {
                alert(res.message);
                }
            }),
        failure: (reponse) => {
            alert("Some thing Wrong Happend");
          
        },
        error: (response) => {
            lert("Some thing Wrong Happend");
          
        }


    });
  
}











// Options to be given as parameter 
// in fetch for making requests
// other then GET


// Fake api for making post requests
