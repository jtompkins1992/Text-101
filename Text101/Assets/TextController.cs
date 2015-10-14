using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {room, investigate_0, wardrobe_0, mars_bar, investigate_1, wardrobe_1, floor_0, search, desk, floor_1, door_0, bed, take_keys, 
						door_1, kitchen_0, front_door, kitchen_1, hob_0, fridge_0, cupboards_0, fridge_1, cupboards_1, hob_1, cupboards_2, hob_2, fridge_2,
						cupboards_3, fridge_3, hob_3, assess, lounge_0, bathroom_0, sofas_0, tv_0, pizza_boxes_0, coat_of_arms_0, curtain_0, sink_0, 
						chipsticks_0, lounge_1, lounge_2, get_bacon_0, shake_0, turn_0, bathroom_1, bathroom_2, sofas_1, pizza_boxes_1, bathroom_3, lounge_3,
						sink_1, curtain_1, sink_2, chipsticks_1, sofas_2, tv_1, pizza_boxes_2, coat_of_arms_1, shake_1, turn_1, bathroom_4, lounge_4, 
						get_bacon_1, cook_bacon, sink_3, sofas_3, pizza_boxes_3, escape_0, escape_1};
	private States myState;
	  
	// Use this for initialization
	void Start () {myState=States.room;}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.room)						{room();}
		else if (myState == States.investigate_0)				{investigate_0();}
		else if (myState == States.wardrobe_0)					{wardrobe_0();}
		else if (myState == States.mars_bar)					{mars_bar();}
		else if (myState == States.investigate_1)				{investigate_1();}
		else if (myState == States.wardrobe_1)					{wardrobe_1();}
		else if (myState == States.floor_0)						{floor_0();}
		else if (myState == States.search) 						{search();}
		else if (myState == States.desk) 						{desk();}
		else if (myState == States.floor_1) 					{floor_1();}
		else if (myState == States.door_0) 						{door_0();}
		else if (myState == States.bed)							{bed();}
		else if (myState == States.take_keys) 					{take_keys();}	
		else if (myState == States.door_1)						{door_1();}
		else if (myState == States.kitchen_0) 					{kitchen_0();} 
		else if (myState == States.front_door) 					{front_door();} 
		else if (myState == States.kitchen_1) 					{kitchen_1();} 
		else if (myState == States.hob_0) 						{hob_0();}
		else if (myState == States.fridge_0)					{fridge_0();}
		else if (myState == States.cupboards_0)					{cupboards_0();}
		else if (myState == States.fridge_1)					{fridge_1();}
		else if (myState == States.cupboards_1)					{cupboards_1();}
		else if (myState == States.hob_1) 						{hob_1();}
		else if (myState == States.cupboards_2)					{cupboards_2();}
		else if (myState == States.hob_2) 						{hob_2();}
		else if (myState == States.fridge_2)					{fridge_2();}
		else if (myState == States.cupboards_3)					{cupboards_3();}
		else if (myState == States.fridge_3)					{fridge_3();}
		else if (myState == States.hob_3) 						{hob_3();}
		else if (myState == States.assess) 						{assess();}
		else if (myState == States.lounge_0) 					{lounge_0();}
		else if (myState == States.bathroom_0) 					{bathroom_0();}
		else if (myState == States.cupboards_3)					{cupboards_3();}
		else if (myState == States.fridge_3)					{fridge_3();}
		else if (myState == States.hob_3) 						{hob_3();}
		else if (myState == States.assess) 						{assess();}
		else if (myState == States.lounge_0) 					{lounge_0();}
		else if (myState == States.bathroom_0) 					{bathroom_0();}
		else if (myState == States.sofas_0)						{sofas_0();}
		else if (myState == States.tv_0)						{tv_0();}
		else if (myState == States.pizza_boxes_0) 				{pizza_boxes_0();}
		else if (myState == States.coat_of_arms_0) 				{coat_of_arms_0();}
		else if (myState == States.curtain_0) 					{curtain_0();}
		else if (myState == States.sink_0) 						{sink_0();}
		else if (myState == States.chipsticks_0) 				{chipsticks_0();}
		else if (myState == States.lounge_1) 					{lounge_1();}
		else if (myState == States.lounge_2)					{lounge_2();}
		else if (myState == States.get_bacon_0) 				{get_bacon_0();}
		else if (myState == States.shake_0) 					{shake_0();}
		else if (myState == States.turn_0) 						{turn_0();}
		else if (myState == States.bathroom_1) 					{bathroom_1();}
		else if (myState == States.bathroom_2) 					{bathroom_2();}
		else if (myState == States.sofas_1) 					{sofas_1();}
		else if (myState == States.pizza_boxes_1)				{pizza_boxes_1();} 
		else if (myState == States.bathroom_3) 					{bathroom_3();}
		else if (myState == States.lounge_3)					{lounge_3();} 
		else if (myState == States.sink_1)						{sink_1();}
		else if (myState == States.curtain_1) 					{curtain_1();}
		else if (myState == States.sink_2) 						{sink_2();}
		else if (myState == States.chipsticks_1) 				{chipsticks_1();}
		else if (myState == States.sofas_2)						{sofas_2();}
		else if (myState == States.tv_1)						{tv_1();}
		else if (myState == States.pizza_boxes_2) 				{pizza_boxes_2();}
		else if (myState == States.coat_of_arms_1) 				{coat_of_arms_1();}
		else if (myState == States.shake_1) 					{shake_1();}
		else if (myState == States.turn_1) 						{turn_1();}
		else if (myState == States.bathroom_4) 					{bathroom_4();}
		else if (myState == States.lounge_4)					{lounge_4();}
		else if (myState == States.get_bacon_1) 				{get_bacon_1();}
		else if (myState == States.cook_bacon) 					{cook_bacon();}
		else if (myState == States.sink_3) 						{sink_3();}
		else if (myState == States.sofas_3) 					{sofas_3();}
		else if (myState == States.pizza_boxes_3)				{pizza_boxes_3();}
		else if (myState == States.escape_0)					{escape_0();} 
		else if (myState == States.escape_1)					{escape_1();} 
	}
	
	#region state handler methods	
	void room () {
		text.text = "You wake up in a double bed in a student house. You are extremely hungover and realise that last night, mistakes were made. " +
					"Next to you is a naked girl in her early 20's but your intense feeling of joy changes to fear as you realise you can't remember " +
					"her name. You check under the covers; yep, you're also naked. \"Christ...\" you mutter to yourself. You need to get out of here " +
					"before this girl wakes up! First you need to find your clothes.\n\n " +
					"Press I to inspect the room"; 
		
		if (Input.GetKeyDown(KeyCode.I))		{myState = States.investigate_0;} 
	}
	
	void investigate_0 () {
		text.text = "Looking around the room, you see some classic indicators of a student house; a wardrobe full of clothes, various pieces of paper and " +
					"sports equipment littering the floor and a half-eaten mars bar on the bedside table.\n\nPress W to search the wardrobe, press F " +
					"to search the floor or press M to eat the mars bar";
					
		if (Input.GetKeyDown (KeyCode.W))		{myState = States.wardrobe_0;}
		else if (Input.GetKeyDown (KeyCode.F))	{myState = States.floor_0;}
		else if (Input.GetKeyDown (KeyCode.M))	{myState = States.mars_bar;}
	}
	
	void wardrobe_0 () {
		text.text = "You search through the wardrobe in a silent frenzy for any male oriented clothing. Unfortunately it contains only dresses, skirts " +
					"and for some reason a penguin onesie. On a student night at the local nightclub, a penguin onesie would be seen as a credible attire " +
					"however as its 9am on a sunday and you wish to leave unnoticed, you decide against it.\n\nPress I to return to investigating the room";
					
		if (Input.GetKeyDown (KeyCode.I))		{myState = States.investigate_0;}    					
	}

	void mars_bar () {
		text.text = "You check to make sure the girl is still asleep before devouring the mars bar in 2 seconds flat. You will have to face the shame and " +
					"repurcussions of your actions another day.\n\nPress I to return to investigating the room.";
					
		if (Input.GetKeyDown (KeyCode.I))		{myState = States.investigate_1;}
	}
	
	void investigate_1 () {
		text.text = "Looking around the room, you see some classic indicators of a student house; a wardrobe full of clothes, various pieces of paper and " +
					"sports equipment littering the floor and, sadly, a now empty mars bar wrapper on the bedside table.\n\nPress W to search the " +
					"wardrobe or press F to search the floor";
		
		if (Input.GetKeyDown (KeyCode.W))		{myState = States.wardrobe_1;}
		else if (Input.GetKeyDown (KeyCode.F))	{myState = States.floor_0;} 
	}
	
	void wardrobe_1 () {
		text.text = "You search through the wardrobe in a silent frenzy for any male oriented clothing. Unfortunately it contains only dresses, skirts " +
					"and for some reason a penguin onesie. On a student night at the local nightclub, a penguin onesie would be seen as a credible attire " +
					"however as its 9am on a sunday and you wish to leave unnoticed, you decide against it.\n\nPress I to return to investigating the room";
		
		if (Input.GetKeyDown (KeyCode.I))		{myState = States.investigate_1;}
	}
	
	void floor_0 (){
		text.text = "You scrabble about on the floor, sifting through the sea of papers and manage to find all of the items of clothing you were wearing " +
					"yesterday except for your left sock. This is a sacrifice you are willing to make and plus these socks don't have your name sewn into " +
					"them so there is no fear of her tracking you down on facebook. You quickly get dressed and head for the door. It's locked. You will " +
					"have to find the key!\n\nPress S to search the room";
					
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.search;} 
	}
    
    void search (){
    	text.text = "The most logical places that the key could be are the desk in the corner, somewhere on the floor or under the bed.\n\nPress D to " +
    				"search the desk, press F to search the floor, press B to search under the bed or press C to check the door.";
    	
    	if (Input.GetKeyDown (KeyCode.D))		{myState = States.desk;}
    	else if (Input.GetKeyDown (KeyCode.F))	{myState = States.floor_1;}
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.door_0;}
		else if (Input.GetKeyDown (KeyCode.B)) 	{myState = States.bed;}
    }
    
	void desk(){
		text.text = "The desk is covered with text books, maps and colouring pencils so you deduce that she must study geography. The only other thing of " +
					"interest is a bright pink laptop covered with cat stickers. You were always more of a dog person anyway.\n\nPress S to continue to " +
					"search the room";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.search;}
	}
	
	void floor_1(){
		text.text = "Further inspection of the floor reveals nothing except that this girl is extremely messy. Make-up and used pots of various creams " +
					"litter the floor as well the girl's recently worn undergraments. You also find a used condom wrapper and wonder whether this is from " +
					"the night before or from one of the girl's previous liasons. Either way you don't really want to stay to find out.\n\nPress S to " +
					"continue to search the room.";
					         
         if (Input.GetKeyDown (KeyCode.S))		{myState = States.search;}
    }
    
	void door_0(){
		text.text = "The door is quite sturdy but moves slightly when you twist the handle. You could force it open but you don't want to wake the girl " +
					"and you would feel bad if she lost her deposit. The key has got to be somewhere in this room.\n\nPress S to continue to search the " +
					"room";
		
		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.search;}
	}
	
	void bed(){
		text.text = "You look under the bed and amongst the boxes and various pairs of brown shoes, you find a bag that you deduce the girl must " +
					"take to uni. It contains a day-to-day planner, an ipad and something shiny at the bottom!\n\nPress C to take a closer look";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.take_keys;}
   }
	
	void take_keys(){
		text.text = "You found some keys! One of these must fit the room's lock and hopefully you can use one of the others to unlock the front door.\n\n" +
					"Press D to go to the door";
		
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.door_1;}
	}
	
	void door_1(){
		text.text = "You check to see if any of the keys fit. Result! The second one you try works. You open the door quietly and find your other sock on " +
					"the other sides handle. You pocket the sock to remove any evidence of your presence. You are on the second floor and the stairs are " +
					"to your right. As you make your way down the stairs, you start to think that you are in the clear however you then see the front " +
					"door...\n\nPress C to continue";
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.front_door;}
	}			
	
	void front_door(){
		text.text = "Guests of last nights house party are still here but they are passed out in the hall. Two big guys wearing togas are " +
					"slumped against the front door blocking you in. Waking them unnaturally could cause harm to you and the house. There must be another " +
					"way out! You think that maybe the kitchen will have a back door.\n\nPress K to go to the kitchen";
		
		if (Input.GetKeyDown (KeyCode.K)) 		{myState = States.kitchen_0;}
	}
	
	void kitchen_0(){
		text.text = "You go into the kitchen and unfortunately there is no back door. You're about to give up hope when you have an idea; students love " +
					"food! Perhaps the smell of a fry up could wake the two lads in the hallway. You decide to investigate the kitchen for ingredients " +
					"and utensils for making a full english breakfast.\n\nPress K to investigate the kitchen";
		
		if (Input.GetKeyDown (KeyCode.K))		{myState = States.kitchen_1;}
	}
	
	void kitchen_1(){
		text.text = "The kitchen is quite basic; there is a hob, a fridge and there are various cupboards dotted about.\n\nPress H to look at the hob, " +
					"press F to inspect the fridge or press C to check the cupboards";
					 
		if (Input.GetKeyDown (KeyCode.H))		{myState = States.hob_0;}
		else if (Input.GetKeyDown (KeyCode.F))	{myState = States.fridge_0;} 
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.cupboards_0;}
	}
	
	void hob_0(){
		text.text = "Upon inspection of the hob you find a used spatula. You can use this! You put it in the sink, fill it with water and then leave " +
					"it to soak.\n\nPress F to inspect the fridge or press C to check the cupboards";
		
		if (Input.GetKeyDown (KeyCode.F))		{myState = States.fridge_1;}
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.cupboards_1;} 
	}
	
	void fridge_0(){
		text.text = "You open the fridge; its completely full of beer. The only food inside is a bunch of carrots. At least someones getting their 5 a " +
					"day.\n\nPress H to look at the hob or press C to check the cupboards";
		
		if (Input.GetKeyDown (KeyCode.H))		{myState =States.hob_1;}
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.cupboards_2;}
	}
	
	void cupboards_0(){
		text.text = "You check the cupboards. All the food you find is either stale or is a vegetable. Obviously they haven't gone on the weekly shop " +
					"yet.\n\nPress H to look at the hob or press F to inspect the fridge";
				
		if (Input.GetKeyDown (KeyCode.H))		{myState = States.hob_2;}
		else if (Input.GetKeyDown (KeyCode.F))	{myState = States.fridge_2;}
	}
	
	void fridge_1(){
		text.text = "You open the fridge; its completely full of beer. The only food inside is a bunch of carrots. At least someones getting their 5 a " +
					"day.\n\nPress C to check the cupboards";
			
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.cupboards_3;}
	}
	
	void cupboards_1(){
		text.text = "You check the cupboards. All the food you find is either stale or is a vegetable. Obviously they haven't gone on the weekly shop " +
					"yet.\n\nPress F to inspect the fridge";
			
		if (Input.GetKeyDown (KeyCode.F))		{myState = States.fridge_3;}
	}
	
	void hob_1(){
		text.text = "Upon inspection of the hob you find a used spatula. You can use this! You put it in the sink, fill it with water and then leave " +
					"it to soak.\n\nPress C to check the cupboards";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.cupboards_3;} 
	}
	
	void cupboards_2(){
		text.text = "You check the cupboards. All the food you find is either stale or is a vegetable. Obviously they haven't gone on the weekly shop " +
					"yet.\n\nPress H to look at the hob";
		
		if (Input.GetKeyDown (KeyCode.H))		{myState = States.hob_3;}
	}
	
	void hob_2(){
		text.text = "Upon inspection of the hob you find a used spatula. You can use this! You put it in the sink, fill it with water and then leave " +
					"it to soak.\n\nPress F to inspect the fridge";
		
		if (Input.GetKeyDown (KeyCode.F))		{myState = States.fridge_3;} 
	}
	
	void fridge_2(){
		text.text = "You open the fridge; its completely full of beer. The only food inside is a bunch of carrots. At least someone is getting their 5 a " +
					"day.\n\nPress H to look at the hob";
		
		if (Input.GetKeyDown (KeyCode.H))		{myState = States.hob_3;}
	}
	
	void cupboards_3(){
		text.text = "You check the cupboards. All the food you find is either stale or is a vegetable. Obviously they haven't gone on the weekly shop " +
					"yet.\n\nPress A to assess the situation";
		
		if (Input.GetKeyDown (KeyCode.A))		{myState = States.assess;}
	}
	
	void fridge_3(){
		text.text = "You open the fridge; its completely full of beer. The only food inside is a bunch of carrots. At least someone is getting their 5 a " +
					"day.\n\nPress A to assess the situation";
		
		if (Input.GetKeyDown (KeyCode.A))		{myState = States.assess;}
	}
	
	void hob_3(){
		text.text = "Upon inspection of the hob you find a used spatula. You can use this! You put it in the sink, fill it with water and then leave " +
					"it to soak.\n\nPress A to assess the situation";
		
		if (Input.GetKeyDown (KeyCode.A))		{myState = States.assess;} 
	}
	
	void assess(){
		text.text = "After looking through the entire kitchen you realise you need to start looking in other rooms for some food and some kind of " +
					"saucepan. Apart from the students rooms, there is a lounge you passed to get to the kitchen and there is a bathroom next to the " +
					"girl's room. Perhaps one of those rooms will have something you need.\n\nPress L to investigate the lounge or press B to investigate " +
					"the bathroom";
		
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.lounge_0;}
		else if (Input.GetKeyDown (KeyCode.B))	{myState = States.bathroom_0;}
	}
	
	void lounge_0(){
		text.text = "You decide to look around the lounge. It has a couple of battered sofas, a small tv and pizza boxes piled in a corner. One thing " +
					"catches your eye however; a canvas picture of a coat of arms is situated above the fireplace.\n\nPress S to look under the sofas, " +
					"press T to check the tv, press P to check the pizza boxes or press C to inspect the coat of arms";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.sofas_0;}
		else if (Input.GetKeyDown (KeyCode.T))	{myState = States.tv_0;} 
		else if (Input.GetKeyDown (KeyCode.P))	{myState = States.pizza_boxes_0;} 
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.coat_of_arms_0;} 
	}	
	
	void bathroom_0(){
		text.text = "You decide to look around the bathroom. It is very basic and quite small. It has a toilet, shower, sink and a bathtub. The shower " +
					"curtain is closed however you can hear a weird noise coming from behind it. It looks like someone threw up in the sink but the " +
					"toilet is remarkably clean. It has an unopened packet of chipsticks on top of the closed toilet seat.\n\nPress C to check behind " +
					"the curtain, press S to look at the sink, press T to investigate the chipsticks on the toilet seat";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.curtain_0;}
		else if (Input.GetKeyDown (KeyCode.S))	{myState = States.sink_0;} 
		else if (Input.GetKeyDown (KeyCode.T))	{myState = States.chipsticks_0;} 			   
	}
	
	void sofas_0(){
		text.text = "You check under both sofas and apart from some scummy skip packets and some bike lube, there is nothing of interest.\n\nPress S to " +
					"continue to search the lounge."; 
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_1;}
	}
	
	void tv_0(){
		text.text = "The tv might be small but you can tell its used alot. There are loads of wires coming out of the back of it and various game consoles " +
					"attached. You accidently step on a cd case as you try to see if there is anything behind the tv. You check to see if the disk is ok " +
					"but it's snapped in half. You close the case and hide it under the tv stand. Hopefully the party will get blamed for the sudden " +
					"disappearance of \"The Trevor Nelson Collection: Volume 4\".\n\nPress S to continue to search the lounge.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_2;}
	}
	
	void pizza_boxes_0(){
		text.text =	"Unfortunately, last night everyone was hungry. All the pizza has been eaten and even the crusts are gone. Dominos must be making a " +
					"killing.\n\nPress S to continue to search the lounge.";
					
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_1;}
	}
	
	void coat_of_arms_0(){
		text.text =	"The coat of arms is in the shape of a shield separated into quadrants. On each quadrant is an animal; there is a goat, an " + 
					"elephant, a peacock and a seal. It looks like the people who lived here made it themselves, probably using photoshop. It would " +
					"actually look quite cool if it wasn't for the bright orange background that they mounted it on. It looks like the coat of arms " +
					"has been knocked slightly and you can see something behind it.\n\nPress I to investigate";
					
		if (Input.GetKeyDown (KeyCode.I))		{myState = States.get_bacon_0;}
	}
	
	void curtain_0(){			  	  			      			      	  			      			  			  	  			      			      	  			      			    
		text.text = "Pulling back the curtain you realise this bathroom is occupied. You find a guy wrapped in white bedsheets fast asleep in the bath " + 
					"tub, clutching a metal frying pan close to his chest. That would perfect for making the breakfast! But somehow you need to wake this " +
					"guy up...\n\nPress S to shake him awake or Press T to turn the shower on";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.shake_0;}
		else if (Input.GetKeyDown (KeyCode.T))	{myState =States.turn_0;}
	}
	
	void sink_0(){
		text.text =	"The sink is full to the brim of luminous yellow chund that looks like the insides of a minion. Definitely not going to find anything " +
					"useful in there.\n\nPress S to continue to search the bathroom.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.bathroom_1;}
	}
	
	void chipsticks_0(){
		text.text =	"The chipsticks are calling out to you to be eaten. You pick them up, open the packet and sit on the toilet munching away. You've always " +
					"had a soft spot for crisps. Soon you are just holding another empty packet. You put the empty packet in the bin next to the toilet and " +
					"get up to start investigating again.\n\nPress S to continue searching the bathroom";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.bathroom_2;}
	}
	
	void lounge_1(){
		text.text = "The lounge has a couple of battered sofas, a small tv and pizza boxes piled in a corner. One thing " +
					"catches your eye however; a canvas picture of a coat of arms is situated above the fireplace.\n\nPress S to look under the sofas, " +
					"press T to check the tv, press P to check the pizza boxes or press C to inspect the coat of arms";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.sofas_0;}
		else if (Input.GetKeyDown (KeyCode.T))	{myState = States.tv_0;} 
		else if (Input.GetKeyDown (KeyCode.P))	{myState = States.pizza_boxes_0;} 
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.coat_of_arms_0;}
	}
	
	void lounge_2(){
		text.text = "The lounge has a couple of battered sofas, a small tv and pizza boxes piled in a corner. One thing " +
					"catches your eye however; a canvas picture of a coat of arms is situated above the fireplace.\n\nPress S to look under the sofas, " +
					"press P to check the pizza boxes or press C to inspect the coat of arms";
			
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.sofas_1;}
		else if (Input.GetKeyDown (KeyCode.P))	{myState = States.pizza_boxes_1;} 
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.coat_of_arms_0;}
	}	
		
	void get_bacon_0(){			  	  			      			      	  			      			  			  	  			      			      	  			      			    
		text.text = "You take the coat of arms off the wall and on the back you find a tesco bag containing someones stash of emergency bacon!. You don't " +
					"know how long its been there but time is running out so you have no qualms with cooking it. You take the bacon to the kitchen and " + 
					"put it on the side next to the hob. You decide to investigate the bathroom for anything else useful before you start cooking.\n\n" +
					"Press B to go to the bathroom";
		
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.bathroom_3;}
	}
		
	void shake_0(){
		text.text =	"You try to shake the guy awake but he's having none of it. He pushes you away and tells you to piss off. Looks like you're gonna " +
					"have to do this the hard way.\n\nPress T to turn the shower on.";
		
		if (Input.GetKeyDown (KeyCode.T))		{myState = States.turn_0;}
	}
		
	void turn_0(){
		text.text =	"You turn the shower fully on and a torrent of cold water bursts from the shower head. Within seconds, the lazy student is on " +
					"his feet screaming and swearing at you to turn it off. He falls out of the shower and starts shouting at you. You can tell " +
					"he's still drunk and a bit stoned so you tell him to go to bed. He slinks off to one of the bedrooms, still clutching his bed " +
					"sheet. Luckily he has left the frying pan behind! You take it down to the kitchen and leave it next to the hob. Now to check " +
					"the lounge.\n\nPress L to go to the lounge";
		
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.lounge_3;}
	}
	
	void bathroom_1(){
		text.text = "The bathroom is very basic and quite small. It has a toilet, shower, sink and a bathtub. The shower curtain is closed however you " +
					"can hear a weird noise coming from behind it. It looks like someone threw up in the sink but the toilet is remarkably clean. It has " +
					"an unopened packet of chipsticks on top of the closed toilet seat.\n\nPress C to check behind the curtain, press S to look at the " +
					"sink, press T to investigate the chipsticks on the toilet seat";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.curtain_0;}
		else if (Input.GetKeyDown (KeyCode.S))	{myState = States.sink_0;} 
		else if (Input.GetKeyDown (KeyCode.T))	{myState = States.chipsticks_0;} 
	}
	
	void bathroom_2(){
		text.text = "The bathroom is very basic and quite small. It has a toilet, shower, sink and a bathtub. The shower curtain is closed however you " +
					"can hear a weird noise coming from behind it. It looks like someone threw up in the sink but the toilet is remarkably clean. There " +
					"is no other food in the bathroom.\n\nPress C to check behind the curtain or press S to look at the sink";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.curtain_0;}
		else if (Input.GetKeyDown (KeyCode.S))	{myState = States.sink_1;} 
	}	
	
	void sofas_1(){
		text.text = "You check under both sofas and apart from some scummy skip packets and some bike lube, there is nothing of interest.\n\nPress S to " +
					"continue to search the lounge."; 
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_2;}
	}
			
	void pizza_boxes_1(){
		text.text =	"Unfortunately, last night everyone was hungry. All the pizza has been eaten and even the crusts are gone. Dominos must be making a " +
					"killing.\n\nPress S to continue to search the lounge.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_2;}
	}
	
	void bathroom_3(){
		text.text = "It is very basic and quite small. It has a toilet, shower, sink and a bathtub. The shower " +
					"curtain is closed however you can hear a weird noise coming from behind it. It looks like someone threw up in the sink but the " +
					"toilet is remarkably clean. It has an unopened packet of chipsticks on top of the closed toilet seat.\n\nPress C to check behind " +
					"the curtain, press S to look at the sink, press T to investigate the chipsticks on the toilet seat";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.curtain_1;}
		else if (Input.GetKeyDown (KeyCode.S))	{myState = States.sink_2;} 
		else if (Input.GetKeyDown (KeyCode.T))	{myState = States.chipsticks_1;} 			   
	}
	
	void lounge_3(){
		text.text = "The lounge has a couple of battered sofas, a small tv and pizza boxes piled in a corner. One thing catches your eye however; a " +
					"canvas picture of a coat of arms is situated above the fireplace.\n\nPress S to look under the sofas, press T to check the tv, " +
					"press P to check the pizza boxes or press C to inspect the coat of arms";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.sofas_2;}
		else if (Input.GetKeyDown (KeyCode.T))	{myState = States.tv_1;} 
		else if (Input.GetKeyDown (KeyCode.P))	{myState = States.pizza_boxes_2;} 
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.coat_of_arms_1;}
	}
	
	void sink_1(){
		text.text =	"The sink is full to the brim of luminous yellow chund that looks like the insides of a minion. Definitely not going to find anything " +
					"useful in there.\n\nPress S to continue to search the bathroom.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.bathroom_2;}
	}
	
	void curtain_1(){			  	  			      			      	  			      			  			  	  			      			      	  			      			    
		text.text = "Pulling back the curtain you realise this bathroom is occupied. You find a guy wrapped in white bedsheets fast asleep in the bath " + 
					"tub, clutching a metal frying pan close to his chest. That would perfect for making the breakfast! But somehow you need to wake this " +
					"guy up...\n\nPress S to shake him awake or Press T to turn the shower on";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.shake_1;}
		else if (Input.GetKeyDown (KeyCode.T))	{myState =States.turn_1;}
	}
	
	void sink_2(){
		text.text =	"The sink is full to the brim of luminous yellow chund that looks like the insides of a minion. Definitely not going to find anything " +
					"useful in there.\n\nPress S to continue to search the bathroom.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.bathroom_3;}
	}
	
	void chipsticks_1(){
		text.text =	"The chipsticks are calling out to you to be eaten. You pick them up, open the packet and sit on the toilet munching away. You've always " +
					"had a soft spot for crisps. Soon you are just holding another empty packet. You put the empty packet in the bin next to the toilet and " +
					"get up to start investigating again.\n\nPress S to continue searching the bathroom";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.bathroom_4;}
	}
	
	void sofas_2(){
		text.text = "You check under both sofas and apart from some scummy skip packets and some bike lube, there is nothing of interest.\n\nPress S to " +
					"continue to search the lounge."; 
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_3;}
	}
	
	void tv_1(){
		text.text = "The tv might be small but you can tell its used alot. There are loads of wires coming out of the back of it and various game consoles " +
					"attached. You accidently step on a cd case as you try to see if there is anything behind the tv. You check to see if the disk is ok " +
					"but it's snapped in half. You close the case and hide it under the tv stand. Hopefully the party will get blamed for the sudden " +
					"disappearance of \"The Trevor Nelson Collection: Volume 4\".\n\nPress S to continue to search the lounge.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_4;}
	}
	
	void pizza_boxes_2(){
		text.text =	"Unfortunately, last night everyone was hungry. All the pizza has been eaten and even the crusts are gone. Dominos must be making a " +
					"killing.\n\nPress S to continue to search the lounge.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_3;}
	}
	
	void coat_of_arms_1(){
		text.text =	"The coat of arms is in the shape of a shield separated into quadrants. On each quadrant is an animal; there is a goat, an " + 
					"elephant, a peacock and a seal. It looks like the people who lived here made it themselves, probably using photoshop. It would " +
					"actually look quite cool if it wasn't for the bright orange background that they mounted it on. It looks like the coat of arms " +
					"has been knocked slightly and you can see something behind it.\n\nPress I to investigate";
		
		if (Input.GetKeyDown (KeyCode.I))		{myState = States.get_bacon_1;}
	}
	
	void shake_1(){
		text.text =	"You try to shake the guy awake but he's having none of it. He pushes you away and tells you to piss off. Looks like you're gonna " +
					"have to do this the hard way.\n\nPress T to turn the shower on.";
		
		if (Input.GetKeyDown (KeyCode.T))		{myState = States.turn_1;}
	}
	
	void turn_1(){
		text.text =	"You turn the shower fully on and a torrent of cold water bursts from the shower head. Within seconds, the lazy student is on " +
					"his feet screaming and swearing at you to turn it off. He falls out of the shower and starts shouting at you. You can tell " +
					"he's still drunk and a bit stoned so you tell him to go to bed. He slinks off to one of the bedrooms, still clutching his bed " +
					"sheet. Luckily he has left the frying pan behind! You take it down to the kitchen and put it next to the hob. Time to cook some " +
					"bacon!\n\nPress C to cook bacon";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.cook_bacon;}
	}
	
	void bathroom_4(){
		text.text = "The bathroom is very basic and quite small. It has a toilet, shower, sink and a bathtub. The shower curtain is closed however you " +
					"can hear a weird noise coming from behind it. It looks like someone threw up in the sink but the toilet is remarkably clean. There " +
					"is no other food in the bathroom.\n\nPress C to check behind the curtain or press S to look at the sink";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.curtain_1;}
		else if (Input.GetKeyDown (KeyCode.S))	{myState = States.sink_3;} 
	}
	
	void lounge_4(){
		text.text = "The lounge has a couple of battered sofas, a small tv and pizza boxes piled in a corner. One thing " +
					"catches your eye however; a canvas picture of a coat of arms is situated above the fireplace.\n\nPress S to look under the sofas, " +
					"press P to check the pizza boxes or press C to inspect the coat of arms";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.sofas_3;}
		else if (Input.GetKeyDown (KeyCode.P))	{myState = States.pizza_boxes_3;} 
		else if (Input.GetKeyDown (KeyCode.C))	{myState = States.coat_of_arms_1;}
	}
	
	void get_bacon_1(){			  	  			      			      	  			      			  			  	  			      			      	  			      			    
		text.text = "You take the coat of arms off the wall and on the back you find a tesco bag containing someones stash of emergency bacon!. You don't " +
					"know how long its been there but time is running out so you have no qualms with cooking it. You take the bacon to the kitchen and " + 
					"put it on the side next to the hob. Time to cook some bacon!\n\nPress C to cook bacon";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.cook_bacon;}
	}	
	
	void cook_bacon(){			  	  			      			      	  			      			  			  	  			      			      	  			      			    
		text.text = "You place the frying pan on the hob, turn it on and add bacon! After a minute or two the bacon starts to sizzle. You turn it with " +
					"the spatula and start to hear movement in the hallway. Suddenly the two guys burst into the kitchen and ask whether they can have " +
					"some of the bacon. You tell them to have some and they take over the cooking. They are so preoccupied they don't notice you sneak " +
					"into the hallway...\n\nPress E to make your escape!";
		
		if (Input.GetKeyDown (KeyCode.E))		{myState = States.escape_0;}
	}				
	
	void sink_3(){
		text.text =	"The sink is full to the brim of luminous yellow chund that looks like the insides of a minion. Definitely not going to find anything " +
					"useful in there.\n\nPress S to continue to search the bathroom.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.bathroom_4;}
	}
	
	void sofas_3(){
		text.text = "You check under both sofas and apart from some scummy skip packets and some bike lube, there is nothing of interest.\n\nPress S to " +
					"continue to search the lounge."; 
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_4;}
	}
	
	void pizza_boxes_3(){
		text.text =	"Unfortunately, last night everyone was hungry. All the pizza has been eaten and even the crusts are gone. Dominos must be making a " +
					"killing.\n\nPress S to continue to search the lounge.";
		
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.lounge_4;}
	}	
	
	void escape_0(){
		text.text =	"You reach the front door and start looking through the girl's bunch of keys. You find the front door key but as you push it into the " +
					"lock you hear a voice.\n\"Dad?\"\nYou turn around to see another girl in her early 20's rubbing sleep from her eyes.\n\"" +
					"Hi sweetheart\"\n\"What are you doing here?\"\nBefore you can answer, the girl with no name appears on the stairs wearing a " +
					"pink dressing gown.\n\nPress C to continue";
		
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.escape_1;}
	}																														
	
	void escape_1(){
		text.text =	"\"Ready for round two?...Oh hi Jacqueline...\"\nJacqueline looks in confusion at her housemate and then back to you. " +
					"Suddenly, realisation floods her face and as her eyes fill with tears, she chokes out\n\"Dad. What does Louise mean...\"\n\n" +
					"Mistakes were made.\n\nThanks for playing! To play again press the space bar";
		
		if (Input.GetKeyDown (KeyCode.Space))		{myState = States.room;}
	}	
	
	#endregion
}