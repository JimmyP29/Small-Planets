var dateTimeHelper = {
    convertToReadableString: function (inputDate) {
        var date = new Date(Date.parse(inputDate));
        var day = this.prependZeroForLessThanTen(date.getUTCDate());
        var month = this.prependZeroForLessThanTen(date.getUTCMonth() + 1);
        var year = date.getUTCFullYear();
        var hour = this.prependZeroForLessThanTen(date.getHours());
        var minute = this.prependZeroForLessThanTen(date.getMinutes());
        var second = this.prependZeroForLessThanTen(date.getSeconds());

        return year + "-" + month + "-" + day + " " + hour + ':' + minute + ':' + second;
    },
    prependZeroForLessThanTen: function (number) {
        return number < 10 ? '0' + number : number;
    }
};