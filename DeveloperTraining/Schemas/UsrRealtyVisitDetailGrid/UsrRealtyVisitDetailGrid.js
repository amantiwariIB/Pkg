define("UsrRealtyVisitDetailGrid", [], function() {
	return {
		entitySchemaName: "UsrRealtyVisit",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {
			init: function(){
				this.callParent(arguments);
				this.SubscribeForWebsocketEvents();
			},
			destroy: function(){
				this.callParent(arguments);
				this.UnsubscribeForWebsocketEvents();
			},
			SubscribeForWebsocketEvents: function(){
				this.Terrasoft.ServerCannel.on(this.Terrasoft.EventName.ON_MESSAGE, 
					this.onWebsocketMessage, this);
			},
			UnsubscribeForWebsocketEvents: function(){
				this.Terrasoft.ServerCannel.un(this.Terrasoft.EventName.ON_MESSAGE, 
					this.onWebsocketMessage, this);
			},
			
			onWebsocketMessage: function(scope, message) {
				if (!message) {
					return;
				}
				if (!message.Header){
					return;
				}
				if (message.Header.Sender !== "AutoAddVisits"){
					return;
				}
				this.reloadGridData();
			}
			
		}
	};
});
