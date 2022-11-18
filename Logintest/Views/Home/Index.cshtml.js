var stripe = Stripe('{{公開可能APIキー}}');
var elements = stripe.elements();
// Element作成時に options から スタイルを調整できます.
var style = {
    base: {
        // ここでStyleの調整をします。
        fontSize: '16px',
        color: "#32325d",
    }
};

// card Element のインスタンスを作成
var card = elements.create('card', { style: style });

// マウント
card.mount('#card-element');

/*
 *async function initialize() {
  const response = await fetch("/create-payment-intent", {
    method: "POST",
    headers: 
    body: 
  });
  const { clientSecret } = await response.json();

  const appearance = {
    theme: 'stripe',
  };
  elements = stripe.elements({ appearance, clientSecret });

  const paymentElement = elements.create("payment");
  paymentElement.mount("#payment-element");
}*/