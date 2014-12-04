
function JMessage(msg, isError) {
    $('#jmessage').html(msg);
    if (isError != undefined && isError == true) {
        $('#jmessage').showTopbarMessage({ background: "#f00", close: 3000 });
    } else {
        $('#jmessage').showTopbarMessage({ background: "#093", close: 3000 });
    }
}

function AppDelete(msg, url, fun) {
    var f = "";
    if (fun && fun != null) {
        f = fun;
    }
    var u = "";
    if (url && url != null) {
        u = "$.post('" + url + "', null, function (data) { if(data){ $('#alert').html(data);} });"
    }

    JAlert({
        Message: msg,
        DialogType: "confirm",
        BtnOk: "确定",
        BtnOkClick: "$(this).dialog('close');" + f + u,
        BtnCancel: "取消",
        BtnCancelClick: "$(this).dialog('close');"
    });
    return false;
}

$(function () {
    $(".active").removeClass("active");
    if (_menuID == undefined) {
        _menuID = 0;
    }
    $("a[mid='" + _menuID + "']").parents(".myli").addClass("active");
    $("a[mid='" + _menuID + "']").parent().addClass("active");
});
