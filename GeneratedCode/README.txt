  		-----------------------------------------------------------------------
  		Generated with SimGen v1.0.0
  		Created by Michal Pasternak at Queen's University MASE lab
  		-----------------------------------------------------------------------
  		This generated simulation "simulation" was created by: Michal Pasternak
  		The purpose of this simulation is to:"Challenge Problem 2 Teaser"
  		
  		NOTICE!!!
  		Channel Ref requires port 9000 to be available for connection on the host machine.
  		Channel c1 requires port 9001 to be available for connection on the host machine.
  		Channel c2 requires port 9002 to be available for connection on the host machine.
  		Channel c3 requires port 9003 to be available for connection on the host machine.
  		Channel c4 requires port 9004 to be available for connection on the host machine.
  		-----------------------------------------------------------------------
  		
  		Connecting on Port 9000 will allow you to control: 
player1
,player2
,player3
,player4
,ball
  		Connecting on Port 9001 will allow you to control: 
player1
,ball
  		Connecting on Port 9002 will allow you to control: 
player2
,ball
  		Connecting on Port 9003 will allow you to control: 
player3
,ball
  		Connecting on Port 9004 will allow you to control: 
player4
,ball
  		WARNING: The following instantiated objects can not be controlled: surface 

  		
  		-----------------------------------------------------------------------
  		You can interact with player1 by using these actions:
  		
  		Action: moveForward
  		Message Syntax: player1,moveForward(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: moveRight
  		Message Syntax: player1,moveRight(
 real)
  		Returns:  No Return
  		Description: Move right at this speed
  		Action: setMovement
  		Message Syntax: player1,setMovement(
 real,real,real)
  		Returns:  No Return
  		Description: set the movement of the piece, forward-Back, Left-Right, spin
  		Action: GPS
  		Message Syntax: player1,GPS()
  		Returns: String in form "player1,
real,real;"
  		Description: get the X and Z coordinate
  		Action: getTilt
  		Message Syntax: player1,getTilt()
  		Returns: String in form "player1,
real;"
  		Description: Move forwards at this speed
  		Action: getSuction
  		Message Syntax: player1,getSuction()
  		Returns: String in form "player1,
real;"
  		Description: get the current suction strength
  		Action: setSuction
  		Message Syntax: player1,setSuction(
 real)
  		Returns:  No Return
  		Description: get the current suction strength
  		Action: setTilt
  		Message Syntax: player1,setTilt(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: spin
  		Message Syntax: player1,spin(
 real)
  		Returns:  No Return
  		Description: spin right/left
  		Action: stop
  		Message Syntax: player1,stop()
  		Returns:  No Return
  		Description: set everything to 0
  		
  		-----------------------------------------------------------------------
  		You can interact with player2 by using these actions:
  		
  		Action: moveForward
  		Message Syntax: player2,moveForward(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: moveRight
  		Message Syntax: player2,moveRight(
 real)
  		Returns:  No Return
  		Description: Move right at this speed
  		Action: setMovement
  		Message Syntax: player2,setMovement(
 real,real,real)
  		Returns:  No Return
  		Description: set the movement of the piece, forward-Back, Left-Right, spin
  		Action: GPS
  		Message Syntax: player2,GPS()
  		Returns: String in form "player2,
real,real;"
  		Description: get the X and Z coordinate
  		Action: getTilt
  		Message Syntax: player2,getTilt()
  		Returns: String in form "player2,
real;"
  		Description: Move forwards at this speed
  		Action: getSuction
  		Message Syntax: player2,getSuction()
  		Returns: String in form "player2,
real;"
  		Description: get the current suction strength
  		Action: setSuction
  		Message Syntax: player2,setSuction(
 real)
  		Returns:  No Return
  		Description: get the current suction strength
  		Action: setTilt
  		Message Syntax: player2,setTilt(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: spin
  		Message Syntax: player2,spin(
 real)
  		Returns:  No Return
  		Description: spin right/left
  		Action: stop
  		Message Syntax: player2,stop()
  		Returns:  No Return
  		Description: set everything to 0
  		
  		-----------------------------------------------------------------------
  		You can interact with player3 by using these actions:
  		
  		Action: moveForward
  		Message Syntax: player3,moveForward(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: moveRight
  		Message Syntax: player3,moveRight(
 real)
  		Returns:  No Return
  		Description: Move right at this speed
  		Action: setMovement
  		Message Syntax: player3,setMovement(
 real,real,real)
  		Returns:  No Return
  		Description: set the movement of the piece, forward-Back, Left-Right, spin
  		Action: GPS
  		Message Syntax: player3,GPS()
  		Returns: String in form "player3,
real,real;"
  		Description: get the X and Z coordinate
  		Action: getTilt
  		Message Syntax: player3,getTilt()
  		Returns: String in form "player3,
real;"
  		Description: Move forwards at this speed
  		Action: getSuction
  		Message Syntax: player3,getSuction()
  		Returns: String in form "player3,
real;"
  		Description: get the current suction strength
  		Action: setSuction
  		Message Syntax: player3,setSuction(
 real)
  		Returns:  No Return
  		Description: get the current suction strength
  		Action: setTilt
  		Message Syntax: player3,setTilt(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: spin
  		Message Syntax: player3,spin(
 real)
  		Returns:  No Return
  		Description: spin right/left
  		Action: stop
  		Message Syntax: player3,stop()
  		Returns:  No Return
  		Description: set everything to 0
  		
  		-----------------------------------------------------------------------
  		You can interact with player4 by using these actions:
  		
  		Action: moveForward
  		Message Syntax: player4,moveForward(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: moveRight
  		Message Syntax: player4,moveRight(
 real)
  		Returns:  No Return
  		Description: Move right at this speed
  		Action: setMovement
  		Message Syntax: player4,setMovement(
 real,real,real)
  		Returns:  No Return
  		Description: set the movement of the piece, forward-Back, Left-Right, spin
  		Action: GPS
  		Message Syntax: player4,GPS()
  		Returns: String in form "player4,
real,real;"
  		Description: get the X and Z coordinate
  		Action: getTilt
  		Message Syntax: player4,getTilt()
  		Returns: String in form "player4,
real;"
  		Description: Move forwards at this speed
  		Action: getSuction
  		Message Syntax: player4,getSuction()
  		Returns: String in form "player4,
real;"
  		Description: get the current suction strength
  		Action: setSuction
  		Message Syntax: player4,setSuction(
 real)
  		Returns:  No Return
  		Description: get the current suction strength
  		Action: setTilt
  		Message Syntax: player4,setTilt(
 real)
  		Returns:  No Return
  		Description: Move forwards at this speed
  		Action: spin
  		Message Syntax: player4,spin(
 real)
  		Returns:  No Return
  		Description: spin right/left
  		Action: stop
  		Message Syntax: player4,stop()
  		Returns:  No Return
  		Description: set everything to 0
  		
  		-----------------------------------------------------------------------
  		You can interact with ball by using these actions:
  		
  		Action: GPS
  		Message Syntax: ball,GPS()
  		Returns: String in form "ball,
real,real,real;"
  		Description: no description provided
  		
