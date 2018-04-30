window.onload = function () {
    $.getJSON("api/User/", null, function (data) {
        $.each(data, function (index, item) { // Iterates through a collection
            $("#SelectUser").append( // Append an object to the inside of the select box
                $("<option></option>") // Yes you can do this.
                    .text(item.Name)
                    .val(item.ID)
            );
        });
    });

    $('#SelectUser').change(function () {
        $("ul").empty();
        getData();
    });

   
}

function getData() {
    var e = document.getElementById("SelectUser");
    var userID = e.options[e.selectedIndex].getAttribute("value");
    $.getJSON("api/Order/" + userID, null, function (data) {
        $.each(data, function (index, item) {
            $("#OrderList").append( // Append an object to the inside of the select box
                $("<li></li>") // Yes you can do this.
                    .text(item.OrderName)
            );
        });
    });
}