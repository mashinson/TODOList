
jQuery(document).ready(function () {

    TaskList.initTaskChange();
    TaskList.initTaskEdit();
    TaskList.initTaskDelete();
});

var TaskList = function () {

    return {
        initTaskChange: function () {
            $("input.list-child").each(function () {
                if ($(this).is(':checked')) {
                    $(this).parents('li').addClass("task-done");
                }
            });
            $('input.list-child').change(function () {
                if ($(this).is(':checked')) {
                    $(this).parents('li').addClass("task-done");
                } else {
                    $(this).parents('li').removeClass("task-done");
                };

                var viewModel = {
                    'Task.ID': $(this).parent().parent().children("div.task-title").children("label").attr('id'),
                    'Task.IsDone': $(this).is(':checked'),
                    'Task.Description': $(this).parent().parent().children("div.task-title").children("label").text()
                };
                $.ajax({
                    type: 'POST',
                    dataType: 'json',
                    cache: false,
                    url: '/Home/_EditTask',
                    data: viewModel
                });
            });

        },
        initTaskEdit: function () {

            $('button.editTask').click(function () {
                var label = $(this).closest("div.task-title").children("label");
                var task_ID = label.attr('id');
                var task_Text = label.text();
                var task_IsDone = $(this).parent().parent().parent().children("div.task-checkbox").children("input.list-child").is(':checked');
                $("#editModal #ModelTaskId").val(task_ID);
                $("#editModal #ModelTaskDesc").val(task_Text);
                $("#editModal #ModelTaskIsDone").val(task_IsDone);
            });
         
        },
        initTaskDelete: function () {
            $('button.deleteTask').click(function () {
                var task_ID = $(this).closest("div.task-title").children("label").attr('id');
                $("#deleteModal #delModelTaskId").val(task_ID);
            });
        }
    };

}();