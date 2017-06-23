// ParticipantsManager.cs
// Written by - Y. Yeung (y-squared.net)
// June-2017


using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public struct Participant
{
    // Int = 5 digit participant ID
    // bool : if true = ME Games; else poptropica
    public int idNumber;
    public bool gameToPlay;
    public string urlSite;

    public Participant(int idNumberToSave, bool gameToPlayToSave, string urlToLoad)
    {
        idNumber = idNumberToSave;
        gameToPlay = gameToPlayToSave;
        urlSite = urlToLoad;
    }
}


public class ParticipantsManager : MonoBehaviour
{
    // Participant information
    private Dictionary<int, Participant> participants;

    // palm beach sites
    string fdg = "http://ccpsych.az1.qualtrics.com/jfe/form/SV_d3TQlkkzOHI5rNj ";
    string max = "http://ccpsych.az1.qualtrics.com/jfe/form/SV_898kCinD4HDYdnv";
    string westPalmBeach = "http://ccpsych.az1.qualtrics.com/jfe/form/SV_0iXErrwfuocHXKt";

    Participant registeredParticipant;

    void SetupParticipants()
    {
        // Florida Participants
        participants.Add(02101, new Participant(02101, false, max));
        participants.Add(02102, new Participant(02102, true, max));
        participants.Add(02103, new Participant(02103, false, westPalmBeach));
        participants.Add(02104, new Participant(02104, false, westPalmBeach));
        participants.Add(02105, new Participant(02105, true, max));
        participants.Add(02106, new Participant(02106, true, westPalmBeach));
        participants.Add(02107, new Participant(02107, true, westPalmBeach));
        participants.Add(02108, new Participant(02108, true, westPalmBeach));
        participants.Add(02109, new Participant(02109, false, westPalmBeach));
        participants.Add(02110, new Participant(02110, true, max));
        participants.Add(02111, new Participant(02111, false, fdg));
        participants.Add(02112, new Participant(02112, false, fdg));
        participants.Add(02113, new Participant(02113, false, max));
        participants.Add(02114, new Participant(02114, true, max));
        participants.Add(02115, new Participant(02115, false, max));
        participants.Add(02116, new Participant(02116, true, max));
        participants.Add(02117, new Participant(02117, true, fdg));
        participants.Add(02118, new Participant(02118, false, fdg));
        participants.Add(02119, new Participant(02119, true, max));
        participants.Add(02120, new Participant(02120, false, max));
        participants.Add(02121, new Participant(02121, true, max));
        participants.Add(02122, new Participant(02122, true, westPalmBeach));
        participants.Add(02123, new Participant(02123, false, westPalmBeach));
        participants.Add(02124, new Participant(02124, false, westPalmBeach));
        participants.Add(02125, new Participant(02125, true, fdg));
        participants.Add(02126, new Participant(02126, true, fdg));
        participants.Add(02127, new Participant(02127, true, westPalmBeach));
        participants.Add(02128, new Participant(02128, true, westPalmBeach));
        participants.Add(02129, new Participant(02129, false, westPalmBeach));
        participants.Add(02130, new Participant(02130, true, max));
        participants.Add(02131, new Participant(02131, false, max));
        participants.Add(02132, new Participant(02132, false, max));
        participants.Add(02133, new Participant(02133, false, fdg));
        participants.Add(02134, new Participant(02134, false, fdg));
        participants.Add(02135, new Participant(02135, true, fdg));
        participants.Add(02136, new Participant(02136, false, westPalmBeach));
        participants.Add(02137, new Participant(02137, true, westPalmBeach));
        participants.Add(02138, new Participant(02138, false, westPalmBeach));
        participants.Add(02139, new Participant(02139, false, max));
        participants.Add(02140, new Participant(02140, true, fdg));
        participants.Add(02141, new Participant(02141, true, westPalmBeach));
        participants.Add(02142, new Participant(02142, true, westPalmBeach));
        participants.Add(02143, new Participant(02143, false, max));
        participants.Add(02144, new Participant(02144, false, max));
        participants.Add(02145, new Participant(02145, false, westPalmBeach));
        participants.Add(02146, new Participant(02146, true, westPalmBeach));
        participants.Add(02147, new Participant(02147, true, fdg));
        participants.Add(02148, new Participant(02148, false, fdg));
        participants.Add(02149, new Participant(02149, false, fdg));
        participants.Add(02150, new Participant(02150, true, westPalmBeach));
        participants.Add(02151, new Participant(02151, true, westPalmBeach));
        participants.Add(02152, new Participant(02152, false, westPalmBeach));
        participants.Add(02153, new Participant(02153, true, westPalmBeach));
        participants.Add(02154, new Participant(02154, true, westPalmBeach));
        participants.Add(02155, new Participant(02155, false, westPalmBeach));
        participants.Add(02156, new Participant(02156, false, fdg));
    }

    void SetupDummyIDs()
    {
        participants.Add(77770, new Participant(77770, true, fdg));
        participants.Add(77771, new Participant(77771, true, fdg));
        participants.Add(77772, new Participant(77772, true, fdg));
        participants.Add(77773, new Participant(77773, true, fdg));
        participants.Add(77774, new Participant(77774, true, fdg));
        participants.Add(77775, new Participant(77775, true, westPalmBeach));
        participants.Add(77776, new Participant(77776, true, max));
        participants.Add(77777, new Participant(77777, true, fdg));
    }

    void Start()
    {
        participants = new Dictionary<int, Participant>();
        SetupParticipants();
        SetupDummyIDs();
    }

    public bool ValidatedParticipant(int id)
    {
        if (participants.ContainsKey(id))
        {
            registeredParticipant = participants[id];
            return true;
        }
        return false;
    }

    public bool GetRegisteredParticipantResult()
    {
        return registeredParticipant.gameToPlay;
    }

    public string GetRegisteredParticipantURL()
    {
        return registeredParticipant.urlSite;
    }
}
