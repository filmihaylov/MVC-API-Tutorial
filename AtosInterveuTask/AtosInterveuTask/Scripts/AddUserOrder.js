window.onload = function ()
{
    $('#submitNameOrder').click(function ()
    {
        userName = $('#userName').val();
        orderName = $('#orderName').val();

        $.ajax({
            type: 'POST',
            url: '../api/User/' + userName,
            success: function (data) {
                $.ajax({
                    type: 'POST',
                    url: '../api/Order/' + data.ID + '/' + orderName,
                    success: function (msg) {
                        alert("User and Order Creted");
                    },
                    error: function () {
                        alert("Order Not Created, Only User");
                    }
             
                });
            },
            error: function (jqXHR, exception) {
                alert("User Not Created");
            }
        });
    })

}