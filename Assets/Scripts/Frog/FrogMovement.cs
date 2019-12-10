using UnityEngine;

public class FrogMovement : MonoBehaviour
{
	public int lives = 5;
	[Range(1, 5)]
	public float MovementAmount = 1.0f;

	public float MovementSpeed = 0.1f;

	public float RotationSpeed = 0.1f;

	public Vector3 targetPosition;
	public Quaternion targetRotation;

	public bool shouldMove = true;
	public bool shouldParent = false;

	private Transform parent;

    AudioSource audioFrogMove;

    void Start()
    {
		targetPosition = transform.position;
		targetRotation = transform.rotation;
        audioFrogMove = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (shouldMove)
		{
			transform.position = Vector3.Lerp(transform.position, targetPosition, MovementSpeed);
			transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, RotationSpeed);
            
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
            audioFrogMove.Play();
            shouldParent = false;
			gameObject.transform.parent = null;
			targetPosition += new Vector3(-MovementAmount, 0, 0);
			targetRotation = Quaternion.Euler(0, 90, 0);
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
            audioFrogMove.Play();
            shouldParent = false;
			gameObject.transform.parent = null;
			targetPosition += new Vector3(MovementAmount, 0, 0);
			targetRotation = Quaternion.Euler(0, -90, 0);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
            audioFrogMove.Play();
            shouldParent = false;
			gameObject.transform.parent = null;
			targetPosition += new Vector3(0, 0, -MovementAmount);
			targetRotation = Quaternion.Euler(0, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
            audioFrogMove.Play();
            shouldParent = false;
			gameObject.transform.parent = null;
			targetPosition += new Vector3(0, 0, MovementAmount);
			targetRotation = Quaternion.Euler(0, 180, 0);
		}
	}

	private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Log")
		{
			targetPosition = other.gameObject.transform.position + new Vector3(0, 0.8f, 0);
			shouldParent = true;
		}

        if (other.gameObject.tag == "River")
        {
            targetPosition = new Vector3(0.3081f, 0.322f, 13.247f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Car" || other.gameObject.tag == "Enemy")
        {
			if (lives >= 0)
			{
				lives--;
			}

			gameObject.GetComponent<FrogHacking>().HackingUses = gameObject.GetComponent<FrogHacking>().MaxHackingUses;
			targetPosition = new Vector3(5.360525f, 0.339f, 0.7037842f);
		}

		if (other.gameObject.tag == "Log")
		{
			if (shouldParent)
			{
				targetPosition = other.gameObject.transform.position + new Vector3(0, 0.8f, 0);
			}
		}
	}

	private void OnTriggerExit(Collider other)
    {

	}

	private void OnCollisionExit(Collision collision)
	{

	}
}
