$(function () {
    var fizzbuzzList = $('#fizzbuzz-list');

    for (var i = 1; i <= 100; i++) {
        var output = i;

        if (i % 3 === 0) {
            output = 'fizz';
        }

        if (i % 5 === 0) {
            output = 'buzz';
        }

        if (i % 15 === 0) {
            output = 'fizz buzz';
        }

        fizzbuzzList.append($('<li>' + output + '</li>'));
    }
});