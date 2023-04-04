$(document).ready(function () {
    $('#button1, #button2,#button3,#button4, #button5, #button6,#button7').click(function () {
                alert()
                var buttonValue = $(this).val();
                $('#textbox1').val(buttonValue);
            });
        });
