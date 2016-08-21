using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {cell, sheets_0, lock_0, mirror, cell_mirror, sheets_1, lock_1, corridor_0, 
						staris_0, stairs_1, stairs_2, courtyard, floor, corridor_1, corridor_2, corridor_3, closet_door, in_closet};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell){
			cell ();
		}
		else if (myState == States.sheets_0){
			sheets_0 ();
		}
		else if (myState == States.sheets_1){
			sheets_1 ();
		}
		else if (myState == States.lock_0){
			lock_0 ();
		}
		else if (myState == States.lock_1){
			lock_1 ();
		}
		else if (myState == States.mirror){
			mirror ();
		}
		else if (myState == States.corridor_0){
			corridor_0 ();
		}
		else if (myState == States.cell_mirror){
			cell_mirror ();
		}
		else if (myState == States.staris_0){
			stairs_0 ();
		}
		else if (myState == States.stairs_1){
			stairs_1 ();
		}
		else if (myState == States.stairs_2){
			stairs_2 ();
		}
		else if (myState == States.courtyard){
			courtyard ();
		}
		else if (myState == States.floor){
			floor ();
		}
		else if (myState == States.corridor_1){
			corridor_1 ();
		}
		else if (myState == States.corridor_2){
			corridor_2 ();
		}
		else if (myState == States.corridor_3){
			corridor_3 ();
		}
		else if (myState == States.closet_door){
			closet_door ();
		}
		else if (myState == States.in_closet){
			in_closet ();
		}
	}
	
	void in_closet(){
		text.text = "There is nothing more than cleaning supplies and a cleaner's uniform, who leaves a uniform at work?" +
					"I can put it on as a disguise.\n\n" +
					"Press D to Dress up, or R to Return to the corridor";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_2;
		}
		else if (Input.GetKeyDown(KeyCode.D)){
			myState = States.corridor_3;
		}
	}
	void closet_door() {
		text.text = "Dammit the closet door it's locked. " +
					"Maybe I could find something around to open the door.\n\n" +
					"Press R to Return to the corridor";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	void corridor_3() {
		text.text = "Now that I am in disguise and i was lucky enough that there was a keycard with the uniform," +
					" I can get out without the guards asking any question.\n\n" +
					"Press S to take the Stairs, or U to Undress";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.courtyard;
		}
		else if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.in_closet;
		}
	}
	void corridor_2() {
		text.text = "I don't need a uniform to get out of this place.\n\n" +
					"Press C to revisit the Closet, and S to climb the stairs";
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.in_closet;
		}
		else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_2;
		}
	}
	void corridor_1() {
		text.text = "Now what? I wonder if I can pick the lock with this hairclip.\n\n" +
					"Press P to Pick the lock, and S to climb the stairs";
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.in_closet;
		}
		else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_1;
		}
	}
	void floor () {
		text.text = "This is my lucky day there is a hairclip on the floor.\n\n" +
					"Press R to Return to the standing, or H to take the Hairclip." ;
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
		else if (Input.GetKeyDown(KeyCode.H)) {
			myState = States.corridor_1;
		}
	}
	void courtyard () {
		text.text = "Lets see if this uniform has a little bit of magic. " +
					"Every guard is saluting me as if I am a part of them. " +
					"Now to freedom. The next step, to visit that bastard and give him my regards.\n\n" +
					"Press P to Play again." ;
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
		}
	}
	void stairs_0 (){
		text.text = "This leads to the courtyard, since it is not yet time for the break if I continue I will get caught. " +
					"I think it is best to go back down.\n\n" +
					"Press R to Return to the corridor.";
					
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	void stairs_1 () {
		text.text = "If I walk out to the courtyard with this hairclip I am going to become the guards wife.\n\n" +
					"Press R to Retreat down the stairs" ;
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_1;
		}
	}
	void stairs_2() {
		text.text = "Thanks to the now badly bent hairclip and my merc training I picked the door open. " +
					"Even with the door open it is still not enough to get me through alive.\n\n" +
					"Press R to Return to the corridor";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2;
		}
	}
	void cell () {
		text.text = "Our story begins thanks to our backstabing friend that framed us for a murder he himself committed." +
					" We need to do something to get out of this hell hole of a prison so we can get the son of a bitch who did this to us." +
					" There are some dirty sheets, a mirror, and a locked door from the outside.\n\n" + 
					"Press S to View to View Sheets, M to view Mirror and L to view the Lock"; 
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}
		else if (Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		}
	}
	void sheets_0 () {
		text.text = "I wonder if these sheets are of any use to someone like me. Nothing that comes to mind though since I cannot" +
					" climb out since there are no windows.\n\n" + 
					"Press R to Return to roaming your cell"; 
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	void sheets_1 () {
		text.text = "Holding a mirror to the sheets will not get me out of here any time soon.\n\n" + 
					"Press R to Return to roaming your cell"; 
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	void lock_0 () {
		text.text = "This is an advanced lock only seen in military facilities, the last time I saw one of this" +
					" was in our last mission were all the crazy stuff went down. I remember the code from the last guard" + 
					" but I cannot see the digital keypad.\n\n" + 
					"Press R to Return to your cell"; 
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	void lock_1 () {
		text.text = "I can see now with the mirror through the bars, the keypad. If I remember correctly the guard" +
					" used a code of 4 numbers which where 0567. Let me see if this works.\n\n" + 
					"Press O to Open, or R to Return to your cell"; 
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.corridor_0;
		}
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	void mirror () {
		text.text = "There is a dirty piece of the mirror that is a bit loose.\n\n" + 
					"Press T to Take the mirror, or R to Return to your cell"; 
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
		else if (Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	void cell_mirror () {
		text.text = "Now what to do with this piece of mirror?\n\n" + 
					"Press S to use the Sheets, or L to use the mirror on the Lock."; 
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_1;
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		}
	}
	void corridor_0 () {
		text.text = "Yes finally I got out of that cell, I don't see any guard, now what is the next step?.\n\n" + 
					"Press C to view the Closet, F to inspect the Floor, and S to climb the stairs."; 
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.staris_0;
		}
		else if(Input.GetKeyDown(KeyCode.F)){
			myState = States.floor;
		}
		else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.closet_door;
		}
	}
}
