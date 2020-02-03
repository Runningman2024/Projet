extends KinematicBody2D

const GRAVITY = 1000
const UP = Vector2(0, -1)

var velocity = Vector2()
var speed = 200 

func _ready():
	pass

func _process(delta):
	pass
	
func _physics_process(delta):
	velocity.x =  0
	velocity.y += GRAVITY * delta
	movement_loop()
	
	move_and_slide(velocity, UP)
	
func movement_loop():
	var right = Input.is_action_pressed("ui_right")
	var left = Input.is_action_pressed("ui_left")
	
	var dirx = int(right) - int (left)

	if dirx == -1 :
		velocity.x -= speed
		$Sprite.flip_h = true
	elif dirx == 1:
		velocity.x += speed
		$Sprite.flip_h = false
	else:
		velocity.x = 0