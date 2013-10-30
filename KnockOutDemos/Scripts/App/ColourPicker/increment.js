ko.bindingHandlers.increment = {
    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var $element = $(element);
        var accessor = valueAccessor();
        var options = ko.utils.unwrapObservable(allBindings());
        var incrementBy = options.step || 1;

        $element.on('click', function () {
            var currentValue = accessor();
            if (currentValue) {
                var newValue = currentValue + incrementBy;
                if (newValue <= 255)
                    accessor(currentValue + incrementBy);
                else {
                    accessor(255);
                }
            }
        });
        

    }
};