function OpenDepartment(department)
{
   
        $.ajax({
        type: "GET",
        url: "/Appointment/Check",
        data: { department: department },
        success: function (result) //Pura view uth kr ajaiga Appointment/AppointmentDays"
        {
            $('#modal-form .modal-body').html(result);
            $('#modal-form').modal('show');
        }
    })
}


