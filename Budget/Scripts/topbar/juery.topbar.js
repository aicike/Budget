/*  
    http://www.dailycoding.com/ 
    Topbar message plugin
*/
(function ($) {
    $.fn.showTopbarMessage = function (options) {

        var defaults = {
            background: "#888",
            borderColor: "#000",
            foreColor: "#000",
            height: "50px",
            fontSize: "20px",
            close: "click"
        };
        var options = $.extend(defaults, options);

        var barStyle = " width: 100%;position: fixed;height: " + options.height + ";top: 0px;left: 0px;right: 0px;margin: 0px;display: none;z-index:1000";
        var overlayStyle = "position:relative;top:42px;height: " + options.height + ";filter: alpha(opacity=50);-moz-opacity: 0.5;-khtml-opacity: 0.5;opacity: 0.5;background-color: " + options.background + ";border-bottom: solid 1px " + options.borderColor + ";";
        var messageStyle = " width: 100%;position: relative;top:42px;height: " + options.height + ";top: 0px;left: 0px;right: 0px;margin: 0px;color: " + options.foreColor + ";font-weight: bold;font-size: " + options.fontSize + ";text-align: center;padding: 10px 0px";

        return this.each(function () {
            obj = $(this);

            if ($(".topbarBox").length > 0) {
                // Hide already existing bars
                $(".topbarBox").hide()
                $(".topbarBox").slideUp(200, function () {
                    $(".topbarBox").remove();
                });
            }


            var html = ""
                + "<div class='topbarBox' style='" + barStyle + "'>"
                + "  <div style='" + overlayStyle + "'>&nbsp;</div>"
                + "  <div style='" + messageStyle + "'>" + obj.html() + "</div>"
                + "</div>"

            if (options.close == "click") {
                $(html).click(function () {
                    $(this).slideUp(200, function () {
                        $(this).remove();
                    });
                }).appendTo($('body')).slideDown(200);
            }
            else {
                $(html).appendTo($('body')).slideDown(200).delay(options.close).slideUp(200, function () {
                    $(this).remove();
                });
            }

        });
    };
})(jQuery);