module SerializationPropertyTests
open Expecto
open DotNetLightning.Serialize.Msgs
open Generators

let config =
    { FsCheckConfig.defaultConfig with
            arbitrary = [ typeof<P2PMsgGenerators> ]
        }

[<Tests>]
let tests =
    testList "SerializationPropertyTest" [
        testPropertyWithConfig config "init" <| fun (msg: Init) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "ping" <| fun (msg: Ping) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "pong" <| fun (msg: Pong) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "open_channel" <| fun (msg: OpenChannel) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "accept_channel" <| fun (msg: AcceptChannel) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "funding_created" <| fun (msg: FundingCreated) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "funding_signed" <| fun (msg: FundingSigned) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "funding_locked" <| fun (msg: FundingLocked) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "shutdown" <| fun (msg: Shutdown) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "closing_signed" <| fun (msg: ClosingSigned) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "update_add_htlc" <| fun (msg: UpdateAddHTLC) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "update_fulfill_htlc" <| fun (msg: UpdateFulfillHTLC) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "update_fail_htlc" <| fun (msg: UpdateFailHTLC) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "update_fail_malformed_htlc" <| fun (msg: UpdateFailMalformedHTLC) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "commitment_signed" <| fun (msg: CommitmentSigned) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "revoke_and_ack" <| fun (msg: RevokeAndACK) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "update_fee" <| fun (msg: UpdateFee) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "channel_reestablish" <| fun (msg: ChannelReestablish) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "announcement_signatures" <| fun (msg: AnnouncementSignatures) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "node_announcement" <| fun (msg: NodeAnnouncement) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "channel_announcement" <| fun (msg: ChannelAnnouncement) ->
            Expect.equal (msg.Clone()) (msg) ""

        testPropertyWithConfig config "channel_update" <| fun (msg: ChannelUpdate) ->
            Expect.equal (msg.Clone()) (msg) ""
    ]