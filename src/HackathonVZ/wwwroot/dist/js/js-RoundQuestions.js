$('body').on('change', '.js-category', function () {
    var quizId = $('.js-quizId').val();
    var category = $(this).val();
    var type = $(this).parent().children('.js-type').val();
    var roundId = $(this).parent().children('.js-roundId').val();
    $.ajax({
        url: '/Admin/UpdateRound',
        type: 'POST',
        cache: false,
        async: true,
        data: { category: category, type: type, roundId: roundId, quizId: quizId },
        success: function (result) {
            $('.js-roundsPartial').html(result);
        }
    });
});

$('body').on('change', '.js-type', function () {
    var quizId = $('.js-quizId').val();
    var type = $(this).val();
    var category = $(this).parent().children('.js-category').val();
    var roundId = $(this).parent().children('.js-roundId').val();
    $.ajax({
        url: '/Admin/UpdateRound',
        type: 'POST',
        cache: false,
        async: true,
        data: { category: category, type: type, roundId: roundId, quizId: quizId },
        success: function (result) {
            $('.js-roundsPartial').html(result);
        }
    });
});

$('body').on('click', '.js-modifierButton', function () {
    var modifierId = $(this).parent().children('.js-modifierId').val();
    var questionId = $(this).parent().parent().children('.js-questionId').val();
    $.ajax({
        url: '/Admin/UpdateQuestion',
        type: 'POST',
        cache: false,
        async: true,
        data: { modifierId: modifierId, questionId: questionId },
        success: function (result) {
            $(this).parent().parent().parent().html(result);
        }
    });
});

$('body').on('click', '.js-addRound', function () {
    var quizId = $('.js-quizId').val();
    var numberOfQuestions = $('.js-numberOfQuestions').val();
    var categoryId = $('.js-categoryIdOnCreate').val();
    var typeId = $('.js-typeIdOnCreate').val();
    var turboModifier = false;
    $('.js-turboModifier').on('change', function () {
        turboModifier = $(this).prop('checked');
    });
    $.ajax({
        url: '/Admin/AddRound',
        type: 'POST',
        cache: false,
        async: true,
        data: { quizId: quizId, numberOfQuestions: numberOfQuestions, categoryId: categoryId, typeId: typeId },
        success: function (result) {
            $('.js-roundsPartial').html(result);
        }
    });
});