$(function () {
    $('#button1').on('click', function () {
        var dayOfWeek = $(this).val();
        $.ajax({
            url: '@Url.Action("GetAvailableDoctors", "DoctorInfoes1")',
            type: 'GET',
            data: { dayOfWeek: dayOfWeek },
            success: function (result) {
              //  $('#availableDoctors').html(result);
                $('#modal-form .modal-body').html(result);
                $('#modal-form').modal('show');
            },
            error: function () {
                alert('An error occurred while getting the list of available doctors.');
            }
        });
    });
});

