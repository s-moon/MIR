// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints, 
// and then run "window.location.reload()" in the JavaScript Console.
(function () {
    "use strict";

    var panel = '<div data-role="panel" data-display="reveal" data-theme="a" id="mypanel">' +
                '<ul data-role="listview">' +
                '<li data-icon="home"><a href="#homePage" data-transition="slide">Home</a></li>' +
                '<li data-icon="info"><a href="#aboutPage" data-transition="slide">About</a></li>' +
                '</ul></div>';

    $(document).one('pagebeforecreate', function () {
        $.mobile.pageContainer.prepend(panel);
        $("#mypanel").panel().enhanceWithin();
    });

    document.addEventListener('deviceready', onDeviceReady.bind(this), false);

    setDateAndTime();

    document.getElementById('btnTakePhoto').onclick = function () {
        navigator.camera.getPicture(function (imageUri) {
            document.getElementById('inc-image').innerHTML = "<img src='" + imageUri + "'style='width: 250px; height: 250px;' />";
        }, null, null);
    }

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener( 'resume', onResume.bind( this ), false );
        // TODO: Cordova has been loaded. Perform any initialization that requires Cordova here.
    };

    function onPause() {
        // TODO: This application has been suspended. Save application state here.
    };

    function onResume() {
        // TODO: This application has been reactivated. Restore application state here.
    };

    function setDateAndTime() {
        var currentdate = new Date();
        var date = currentdate.getFullYear() + "-"
                        + (currentdate.getMonth() + 1) + "-"
                        + currentdate.getDate();
        var time = currentdate.getHours() + ":"
                        + currentdate.getMinutes();
        document.getElementById('inc-date').value = date;
        document.getElementById('inc-time').value = time;
    }
} )();