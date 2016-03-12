/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
var app = {
    // Application Constructor
    initialize: function() {
        this.bindEvents();
    },
    // Bind Event Listeners
    //
    // Bind any events that are required on startup. Common events are:
    // 'load', 'deviceready', 'offline', and 'online'.
    bindEvents: function() {
        document.addEventListener('deviceready', this.onDeviceReady, false);
    },
    // deviceready Event Handler
    //
    // The scope of 'this' is the event. In order to call the 'receivedEvent'
    // function, we must explicitly call 'app.receivedEvent(...);'
    onDeviceReady: function() {
        app.receivedEvent('deviceready');
    },
    // Update DOM on a Received Event
    receivedEvent: function(id) {
        var parentElement = document.getElementById(id);
        var listeningElement = parentElement.querySelector('.listening');
        var receivedElement = parentElement.querySelector('.received');

        listeningElement.setAttribute('style', 'display:none;');
        receivedElement.setAttribute('style', 'display:block;');

        console.log('Received Event: ' + id);
    }
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

setDateAndTime();

var panel = '<div data-role="panel" data-display="reveal" data-theme="a" id="mypanel">' +
    '<ul data-role="listview">' +
    '<li data-icon="home"><a href="#homePage" data-transition="slide">Home</a></li>' +
    '<li data-icon="info"><a href="#aboutPage" data-transition="slide">About</a></li>' +
    '</ul></div>';

$(document).one('pagebeforecreate', function () {
    $.mobile.pageContainer.prepend(panel);
    $("#mypanel").panel().enhanceWithin();
});
