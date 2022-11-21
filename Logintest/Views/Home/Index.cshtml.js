var stripe = Stripe('pk_test_51LvqPVCgb8glDeFeUR36pjfxK76LI9ydEBwyOp0DhAM1oAm910nCPX6HBUrhJvgGzZlyRbn0UVaGvsaUaZ4OgOTb00uXxqOXQt');
var elements = stripe.elements();
var style = {
    base: {
        // ここでStyleの調整
        fontSize: '16px',
        color: "#32325d",
    }
};

// card Element のインスタンスを作成
var card = elements.create('card', { style: style });

// マウント
card.mount('#card-element');