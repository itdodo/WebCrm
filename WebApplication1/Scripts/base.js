
$(function() {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": false,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
    //console.log($('#main-content').html());
    $('.main-content').height($(window).height() - 50);
    $('.main-content').niceScroll({
        cursorcolor: "#ccc", //#CC0071 光标颜色 
        cursoropacitymax: 1, //改变不透明度非常光标处于活动状态（scrollabar“可见”状态），范围从1到0 
        touchbehavior: false, //使光标拖动滚动像在台式电脑触摸设备 
        cursorwidth: "5px", //像素光标的宽度 
        cursorborder: "0", //     游标边框css定义 
        cursorborderradius: "5px", //以像素为光标边界半径 
        autohidemode: true //是否隐藏滚动条 
    });

    function onSuccess(data) {
        BUI.Message.Alert('123123', 'success');
        if (data.Code === 200) {
            BUI.Message.Alert(data.Msg, 'success');
        } else {
            BUI.Message.Alert(data.Msg, 'error');
        }

    }
});


function onSuccess(data) {
    //BUI.Message.Alert('123123', 'success');
    if (data.Code === 200) {
        showSuccess(data.Msg);
        //BUI.Message.Alert(data.Msg, 'success');
    } else {
        showError(data.Msg);
        //BUI.Message.Alert(data.Msg, 'error');
    }

}

function ChangeDateFormat(jsondate) {
    jsondate = jsondate.replace("/Date(", "").replace(")/", "");
    if (jsondate.indexOf("+") > 0) {
        jsondate = jsondate.substring(0, jsondate.indexOf("+"));
    }
    else if (jsondate.indexOf("-") > 0) {
        jsondate = jsondate.substring(0, jsondate.indexOf("-"));
    }

    var date = new Date(parseInt(jsondate, 10));
    var month = date.getMonth() + 1 < 10 ? "0" + (date.getMonth() + 1) : date.getMonth() + 1;
    var currentDate = date.getDate() < 10 ? "0" + date.getDate() : date.getDate();
    return date.getFullYear() + "-" + month + "-" + currentDate +" "+ date.toLocaleTimeString();
}

function deleteData() {
    
}

function showSuccess(msg) {
    toastr["success"](msg);
}

function showError(msg) {
    toastr["error"](msg);
}