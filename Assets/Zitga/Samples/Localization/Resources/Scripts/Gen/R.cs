using Cysharp.Threading.Tasks;
using Loxodon.Framework.Localizations;

public static class R
{

    public static class common
    {
        public static UniTask<string> notice_content => Localization.Current.Get("common", "notice_content");

        public static UniTask<string> notice => Localization.Current.Get("common", "notice");

        public static UniTask<string> tap_to_play => Localization.Current.Get("common", "tap_to_play");

        public static UniTask<string> setting => Localization.Current.Get("common", "setting");

        public static UniTask<string> account => Localization.Current.Get("common", "account");

        public static UniTask<string> id => Localization.Current.Get("common", "id");

        public static UniTask<string> summoner => Localization.Current.Get("common", "summoner");

        public static UniTask<string> register_account => Localization.Current.Get("common", "register_account");

        public static UniTask<string> change_password => Localization.Current.Get("common", "change_password");

        public static UniTask<string> switch_server => Localization.Current.Get("common", "switch_server");

        public static UniTask<string> switch_account => Localization.Current.Get("common", "switch_account");

        public static UniTask<string> email_verify => Localization.Current.Get("common", "email_verify");

        public static UniTask<string> game_version => Localization.Current.Get("common", "game_version");

        public static UniTask<string> close => Localization.Current.Get("common", "close");

        public static UniTask<string> closed => Localization.Current.Get("common", "closed");

        public static UniTask<string> sound => Localization.Current.Get("common", "sound");

        public static UniTask<string> music => Localization.Current.Get("common", "music");

        public static UniTask<string> graphic_quality => Localization.Current.Get("common", "graphic_quality");

        public static UniTask<string> low => Localization.Current.Get("common", "low");

        public static UniTask<string> medium => Localization.Current.Get("common", "medium");

        public static UniTask<string> high => Localization.Current.Get("common", "high");

        public static UniTask<string> language => Localization.Current.Get("common", "language");

        public static UniTask<string> language_setting => Localization.Current.Get("common", "language_setting");

        public static UniTask<string> password => Localization.Current.Get("common", "password");

        public static UniTask<string> enter_text => Localization.Current.Get("common", "enter_text");

        public static UniTask<string> forget => Localization.Current.Get("common", "forget");

        public static UniTask<string> do_you_want_restore => Localization.Current.Get("common", "do_you_want_restore");

        public static UniTask<string> register => Localization.Current.Get("common", "register");

        public static UniTask<string> login => Localization.Current.Get("common", "login");

        public static UniTask<string> restore => Localization.Current.Get("common", "restore");

        public static UniTask<string> confirm_password => Localization.Current.Get("common", "confirm_password");

        public static UniTask<string> cancel => Localization.Current.Get("common", "cancel");

        public static UniTask<string> confirm => Localization.Current.Get("common", "confirm");

        public static UniTask<string> new_password => Localization.Current.Get("common", "new_password");

        public static UniTask<string> confirm_new_password => Localization.Current.Get("common", "confirm_new_password");

        public static UniTask<string> please_select_language => Localization.Current.Get("common", "please_select_language");

        public static UniTask<string> daily_checkin => Localization.Current.Get("common", "daily_checkin");

        public static UniTask<string> mail => Localization.Current.Get("common", "mail");

        public static UniTask<string> friend => Localization.Current.Get("common", "friend");

        public static UniTask<string> shop => Localization.Current.Get("common", "shop");

        public static UniTask<string> main_character => Localization.Current.Get("common", "main_character");

        public static UniTask<string> mastery => Localization.Current.Get("common", "mastery");

        public static UniTask<string> inventory => Localization.Current.Get("common", "inventory");

        public static UniTask<string> hero_list => Localization.Current.Get("common", "hero_list");

        public static UniTask<string> event_name => Localization.Current.Get("common", "event_name");

        public static UniTask<string> daily_reward => Localization.Current.Get("common", "daily_reward");

        public static UniTask<string> checkin_progress => Localization.Current.Get("common", "checkin_progress");

        public static UniTask<string> reply => Localization.Current.Get("common", "reply");

        public static UniTask<string> claim => Localization.Current.Get("common", "claim");

        public static UniTask<string> mail_box => Localization.Current.Get("common", "mail_box");

        public static UniTask<string> claim_all => Localization.Current.Get("common", "claim_all");

        public static UniTask<string> system_mail => Localization.Current.Get("common", "system_mail");

        public static UniTask<string> player_mail => Localization.Current.Get("common", "player_mail");

        public static UniTask<string> mail_empty => Localization.Current.Get("common", "mail_empty");

        public static UniTask<string> received_applications => Localization.Current.Get("common", "received_applications");

        public static UniTask<string> recommended_friend => Localization.Current.Get("common", "recommended_friend");

        public static UniTask<string> claim_and_send => Localization.Current.Get("common", "claim_and_send");

        public static UniTask<string> friend_list => Localization.Current.Get("common", "friend_list");

        public static UniTask<string> search => Localization.Current.Get("common", "search");

        public static UniTask<string> friend_request => Localization.Current.Get("common", "friend_request");

        public static UniTask<string> help_fight => Localization.Current.Get("common", "help_fight");

        public static UniTask<string> apply => Localization.Current.Get("common", "apply");

        public static UniTask<string> delete_all => Localization.Current.Get("common", "delete_all");

        public static UniTask<string> delete => Localization.Current.Get("common", "delete");

        public static UniTask<string> scout => Localization.Current.Get("common", "scout");

        public static UniTask<string> ranking_point => Localization.Current.Get("common", "ranking_point");

        public static UniTask<string> ranking_reward => Localization.Current.Get("common", "ranking_reward");

        public static UniTask<string> battle_reward => Localization.Current.Get("common", "battle_reward");

        public static UniTask<string> battle => Localization.Current.Get("common", "battle");

        public static UniTask<string> smash => Localization.Current.Get("common", "smash");

        public static UniTask<string> preview => Localization.Current.Get("common", "preview");

        public static UniTask<string> auto_fill => Localization.Current.Get("common", "auto_fill");

        public static UniTask<string> disassemble => Localization.Current.Get("common", "disassemble");

        public static UniTask<string> heroese => Localization.Current.Get("common", "heroese");

        public static UniTask<string> ok => Localization.Current.Get("common", "ok");

        public static UniTask<string> yes => Localization.Current.Get("common", "yes");

        public static UniTask<string> no => Localization.Current.Get("common", "no");

        public static UniTask<string> not_select_all_hero => Localization.Current.Get("common", "not_select_all_hero");

        public static UniTask<string> do_disassemble_hero_4_star => Localization.Current.Get("common", "do_disassemble_hero_4_star");

        public static UniTask<string> you_need_select_hero => Localization.Current.Get("common", "you_need_select_hero");

        public static UniTask<string> do_you_want_disassemble => Localization.Current.Get("common", "do_you_want_disassemble");

        public static UniTask<string> basic => Localization.Current.Get("common", "basic");

        public static UniTask<string> premium => Localization.Current.Get("common", "premium");

        public static UniTask<string> refresh => Localization.Current.Get("common", "refresh");

        public static UniTask<string> time => Localization.Current.Get("common", "time");

        public static UniTask<string> forge => Localization.Current.Get("common", "forge");

        public static UniTask<string> available_to_forge => Localization.Current.Get("common", "available_to_forge");

        public static UniTask<string> weapon => Localization.Current.Get("common", "weapon");

        public static UniTask<string> armor => Localization.Current.Get("common", "armor");

        public static UniTask<string> helmet => Localization.Current.Get("common", "helmet");

        public static UniTask<string> ring => Localization.Current.Get("common", "ring");

        public static UniTask<string> rank_x => Localization.Current.Get("common", "rank_x");

        public static UniTask<string> season_ranking => Localization.Current.Get("common", "season_ranking");

        public static UniTask<string> point => Localization.Current.Get("common", "point");

        public static UniTask<string> group_ranking => Localization.Current.Get("common", "group_ranking");

        public static UniTask<string> score => Localization.Current.Get("common", "score");

        public static UniTask<string> reward => Localization.Current.Get("common", "reward");

        public static UniTask<string> record => Localization.Current.Get("common", "record");

        public static UniTask<string> defense => Localization.Current.Get("common", "defense");

        public static UniTask<string> choose_rival => Localization.Current.Get("common", "choose_rival");

        public static UniTask<string> change => Localization.Current.Get("common", "change");

        public static UniTask<string> your_current_rank_x => Localization.Current.Get("common", "your_current_rank_x");

        public static UniTask<string> reward_will_sent => Localization.Current.Get("common", "reward_will_sent");

        public static UniTask<string> reward_will_sent_x => Localization.Current.Get("common", "reward_will_sent_x");

        public static UniTask<string> wave => Localization.Current.Get("common", "wave");

        public static UniTask<string> will_open_in => Localization.Current.Get("common", "will_open_in");

        public static UniTask<string> will_end_in => Localization.Current.Get("common", "will_end_in");

        public static UniTask<string> quick => Localization.Current.Get("common", "quick");

        public static UniTask<string> secret_shop => Localization.Current.Get("common", "secret_shop");

        public static UniTask<string> skip => Localization.Current.Get("common", "skip");

        public static UniTask<string> buy => Localization.Current.Get("common", "buy");

        public static UniTask<string> primary_merchant => Localization.Current.Get("common", "primary_merchant");

        public static UniTask<string> medium_merchant => Localization.Current.Get("common", "medium_merchant");

        public static UniTask<string> senior_merchant => Localization.Current.Get("common", "senior_merchant");

        public static UniTask<string> mysterious_merchant => Localization.Current.Get("common", "mysterious_merchant");

        public static UniTask<string> primary => Localization.Current.Get("common", "primary");

        public static UniTask<string> senior => Localization.Current.Get("common", "senior");

        public static UniTask<string> formation => Localization.Current.Get("common", "formation");

        public static UniTask<string> save => Localization.Current.Get("common", "save");

        public static UniTask<string> material => Localization.Current.Get("common", "material");

        public static UniTask<string> upgrade => Localization.Current.Get("common", "upgrade");

        public static UniTask<string> skip_battle => Localization.Current.Get("common", "skip_battle");

        public static UniTask<string> back => Localization.Current.Get("common", "back");

        public static UniTask<string> front => Localization.Current.Get("common", "front");

        public static UniTask<string> gallery => Localization.Current.Get("common", "gallery");

        public static UniTask<string> linking => Localization.Current.Get("common", "linking");

        public static UniTask<string> sort => Localization.Current.Get("common", "sort");

        public static UniTask<string> level => Localization.Current.Get("common", "level");

        public static UniTask<string> star => Localization.Current.Get("common", "star");

        public static UniTask<string> select_hero_altar => Localization.Current.Get("common", "select_hero_altar");

        public static UniTask<string> replay => Localization.Current.Get("common", "replay");

        public static UniTask<string> reward_current_ranking => Localization.Current.Get("common", "reward_current_ranking");

        public static UniTask<string> hero_shard => Localization.Current.Get("common", "hero_shard");

        public static UniTask<string> tap_to_close => Localization.Current.Get("common", "tap_to_close");

        public static UniTask<string> avatar => Localization.Current.Get("common", "avatar");

        public static UniTask<string> border => Localization.Current.Get("common", "border");

        public static UniTask<string> avatar_border => Localization.Current.Get("common", "avatar_border");

        public static UniTask<string> current_avatar => Localization.Current.Get("common", "current_avatar");

        public static UniTask<string> select_avatar => Localization.Current.Get("common", "select_avatar");

        public static UniTask<string> select_border => Localization.Current.Get("common", "select_border");

        public static UniTask<string> world => Localization.Current.Get("common", "world");

        public static UniTask<string> send => Localization.Current.Get("common", "send");

        public static UniTask<string> chat_option_1 => Localization.Current.Get("common", "chat_option_1");

        public static UniTask<string> chat_option_2 => Localization.Current.Get("common", "chat_option_2");

        public static UniTask<string> chat_option_3 => Localization.Current.Get("common", "chat_option_3");

        public static UniTask<string> chat_option_4 => Localization.Current.Get("common", "chat_option_4");

        public static UniTask<string> select_hero_battle => Localization.Current.Get("common", "select_hero_battle");

        public static UniTask<string> vs => Localization.Current.Get("common", "vs");

        public static UniTask<string> hero_info => Localization.Current.Get("common", "hero_info");

        public static UniTask<string> equip => Localization.Current.Get("common", "equip");

        public static UniTask<string> evolve => Localization.Current.Get("common", "evolve");

        public static UniTask<string> skin => Localization.Current.Get("common", "skin");

        public static UniTask<string> level_to_max => Localization.Current.Get("common", "level_to_max");

        public static UniTask<string> level_up => Localization.Current.Get("common", "level_up");

        public static UniTask<string> unlock_level => Localization.Current.Get("common", "unlock_level");

        public static UniTask<string> unequip => Localization.Current.Get("common", "unequip");

        public static UniTask<string> auto_equip => Localization.Current.Get("common", "auto_equip");

        public static UniTask<string> awaken => Localization.Current.Get("common", "awaken");

        public static UniTask<string> switch_character => Localization.Current.Get("common", "switch_character");

        public static UniTask<string> exp => Localization.Current.Get("common", "exp");

        public static UniTask<string> free => Localization.Current.Get("common", "free");

        public static UniTask<string> free_x => Localization.Current.Get("common", "free_x");

        public static UniTask<string> summon => Localization.Current.Get("common", "summon");

        public static UniTask<string> summon_x => Localization.Current.Get("common", "summon_x");

        public static UniTask<string> storage => Localization.Current.Get("common", "storage");

        public static UniTask<string> fragment => Localization.Current.Get("common", "fragment");

        public static UniTask<string> artifact => Localization.Current.Get("common", "artifact");

        public static UniTask<string> leaderboard => Localization.Current.Get("common", "leaderboard");

        public static UniTask<string> quest => Localization.Current.Get("common", "quest");

        public static UniTask<string> damage_stat => Localization.Current.Get("common", "damage_stat");

        public static UniTask<string> notification => Localization.Current.Get("common", "notification");

        public static UniTask<string> spin_x => Localization.Current.Get("common", "spin_x");

        public static UniTask<string> next_force_refresh => Localization.Current.Get("common", "next_force_refresh");

        public static UniTask<string> pack_of_item => Localization.Current.Get("common", "pack_of_item");

        public static UniTask<string> congratulation => Localization.Current.Get("common", "congratulation");

        public static UniTask<string> smash_title => Localization.Current.Get("common", "smash_title");

        public static UniTask<string> select_heroes => Localization.Current.Get("common", "select_heroes");

        public static UniTask<string> requirement => Localization.Current.Get("common", "requirement");

        public static UniTask<string> start => Localization.Current.Get("common", "start");

        public static UniTask<string> quest_refresh_in => Localization.Current.Get("common", "quest_refresh_in");

        public static UniTask<string> speed_up => Localization.Current.Get("common", "speed_up");

        public static UniTask<string> complete => Localization.Current.Get("common", "complete");

        public static UniTask<string> block => Localization.Current.Get("common", "block");

        public static UniTask<string> unblock => Localization.Current.Get("common", "unblock");

        public static UniTask<string> send_mail => Localization.Current.Get("common", "send_mail");

        public static UniTask<string> refresh_in => Localization.Current.Get("common", "refresh_in");

        public static UniTask<string> remaining_attempts => Localization.Current.Get("common", "remaining_attempts");

        public static UniTask<string> challenge => Localization.Current.Get("common", "challenge");

        public static UniTask<string> rename => Localization.Current.Get("common", "rename");

        public static UniTask<string> x_character => Localization.Current.Get("common", "x_character");

        public static UniTask<string> change_avatar => Localization.Current.Get("common", "change_avatar");

        public static UniTask<string> vip => Localization.Current.Get("common", "vip");

        public static UniTask<string> replace_hero => Localization.Current.Get("common", "replace_hero");

        public static UniTask<string> select_your_hero => Localization.Current.Get("common", "select_your_hero");

        public static UniTask<string> please_select_hero_replace => Localization.Current.Get("common", "please_select_hero_replace");

        public static UniTask<string> convert => Localization.Current.Get("common", "convert");

        public static UniTask<string> lock_current_stat => Localization.Current.Get("common", "lock_current_stat");

        public static UniTask<string> upgrade_artifact => Localization.Current.Get("common", "upgrade_artifact");

        public static UniTask<string> select_material_artifact => Localization.Current.Get("common", "select_material_artifact");

        public static UniTask<string> training_hero => Localization.Current.Get("common", "training_hero");

        public static UniTask<string> to_complete_training => Localization.Current.Get("common", "to_complete_training");

        public static UniTask<string> select_item => Localization.Current.Get("common", "select_item");

        public static UniTask<string> map => Localization.Current.Get("common", "map");

        public static UniTask<string> select_material_hero => Localization.Current.Get("common", "select_material_hero");

        public static UniTask<string> select => Localization.Current.Get("common", "select");

        public static UniTask<string> unlock_star => Localization.Current.Get("common", "unlock_star");

        public static UniTask<string> guild_application => Localization.Current.Get("common", "guild_application");

        public static UniTask<string> request_x => Localization.Current.Get("common", "request_x");

        public static UniTask<string> accept => Localization.Current.Get("common", "accept");

        public static UniTask<string> decline => Localization.Current.Get("common", "decline");

        public static UniTask<string> guild_foundation => Localization.Current.Get("common", "guild_foundation");

        public static UniTask<string> recommended => Localization.Current.Get("common", "recommended");

        public static UniTask<string> enter_guild_name_id => Localization.Current.Get("common", "enter_guild_name_id");

        public static UniTask<string> found => Localization.Current.Get("common", "found");

        public static UniTask<string> guild_content => Localization.Current.Get("common", "guild_content");

        public static UniTask<string> member_x => Localization.Current.Get("common", "member_x");

        public static UniTask<string> emblem => Localization.Current.Get("common", "emblem");

        public static UniTask<string> info => Localization.Current.Get("common", "info");

        public static UniTask<string> enter_guild_name => Localization.Current.Get("common", "enter_guild_name");

        public static UniTask<string> enter_guild_info => Localization.Current.Get("common", "enter_guild_info");

        public static UniTask<string> recruit => Localization.Current.Get("common", "recruit");

        public static UniTask<string> daily_boss => Localization.Current.Get("common", "daily_boss");

        public static UniTask<string> checkin => Localization.Current.Get("common", "checkin");

        public static UniTask<string> application => Localization.Current.Get("common", "application");

        public static UniTask<string> input_recruit_info => Localization.Current.Get("common", "input_recruit_info");

        public static UniTask<string> kick => Localization.Current.Get("common", "kick");

        public static UniTask<string> demote => Localization.Current.Get("common", "demote");

        public static UniTask<string> promote => Localization.Current.Get("common", "promote");

        public static UniTask<string> season_reward => Localization.Current.Get("common", "season_reward");

        public static UniTask<string> self_damage => Localization.Current.Get("common", "self_damage");

        public static UniTask<string> guild_damage => Localization.Current.Get("common", "guild_damage");

        public static UniTask<string> level_boss_x => Localization.Current.Get("common", "level_boss_x");

        public static UniTask<string> unlock_at_guild_x => Localization.Current.Get("common", "unlock_at_guild_x");

        public static UniTask<string> current_reward => Localization.Current.Get("common", "current_reward");

        public static UniTask<string> next_reward => Localization.Current.Get("common", "next_reward");

        public static UniTask<string> guild_log => Localization.Current.Get("common", "guild_log");

        public static UniTask<string> stage_reward => Localization.Current.Get("common", "stage_reward");

        public static UniTask<string> map_stage => Localization.Current.Get("common", "map_stage");

        public static UniTask<string> need_input_code => Localization.Current.Get("common", "need_input_code");

        public static UniTask<string> need_input_mail => Localization.Current.Get("common", "need_input_mail");

        public static UniTask<string> input_code_fail => Localization.Current.Get("common", "input_code_fail");

        public static UniTask<string> confirm_new_password_fail => Localization.Current.Get("common", "confirm_new_password_fail");

        public static UniTask<string> need_input_new_password => Localization.Current.Get("common", "need_input_new_password");

        public static UniTask<string> can_not_claim_reward => Localization.Current.Get("common", "can_not_claim_reward");

        public static UniTask<string> max_buy_turn_daily => Localization.Current.Get("common", "max_buy_turn_daily");

        public static UniTask<string> coming_soon => Localization.Current.Get("common", "coming_soon");

        public static UniTask<string> limit_purchase_this_pack => Localization.Current.Get("common", "limit_purchase_this_pack");

        public static UniTask<string> member_kick_guild => Localization.Current.Get("common", "member_kick_guild");

        public static UniTask<string> failed_kick_member => Localization.Current.Get("common", "failed_kick_member");

        public static UniTask<string> login_current_account => Localization.Current.Get("common", "login_current_account");

        public static UniTask<string> member_role_changed => Localization.Current.Get("common", "member_role_changed");

        public static UniTask<string> guild_sub_leader_reached_limit => Localization.Current.Get("common", "guild_sub_leader_reached_limit");

        public static UniTask<string> failed_change_member_role => Localization.Current.Get("common", "failed_change_member_role");

        public static UniTask<string> input_password_failed => Localization.Current.Get("common", "input_password_failed");

        public static UniTask<string> input_user_name_failed => Localization.Current.Get("common", "input_user_name_failed");

        public static UniTask<string> enter_recruit_info_please => Localization.Current.Get("common", "enter_recruit_info_please");

        public static UniTask<string> send_recruit_successful => Localization.Current.Get("common", "send_recruit_successful");

        public static UniTask<string> fail_send_recruit_info => Localization.Current.Get("common", "fail_send_recruit_info");

        public static UniTask<string> fail_get_data => Localization.Current.Get("common", "fail_get_data");

        public static UniTask<string> fail_refresh => Localization.Current.Get("common", "fail_refresh");

        public static UniTask<string> player_joined_guild => Localization.Current.Get("common", "player_joined_guild");

        public static UniTask<string> guild_limit_member => Localization.Current.Get("common", "guild_limit_member");

        public static UniTask<string> need_permission_perform_action => Localization.Current.Get("common", "need_permission_perform_action");

        public static UniTask<string> failed_get_dungeon_stage => Localization.Current.Get("common", "failed_get_dungeon_stage");

        public static UniTask<string> send_request_successful => Localization.Current.Get("common", "send_request_successful");

        public static UniTask<string> already_in_guild => Localization.Current.Get("common", "already_in_guild");

        public static UniTask<string> please_enter_guild_name => Localization.Current.Get("common", "please_enter_guild_name");

        public static UniTask<string> create_guild_success => Localization.Current.Get("common", "create_guild_success");

        public static UniTask<string> create_guild_failed => Localization.Current.Get("common", "create_guild_failed");

        public static UniTask<string> upgrade_guild_success => Localization.Current.Get("common", "upgrade_guild_success");

        public static UniTask<string> challenge_guild_dungeon_success => Localization.Current.Get("common", "challenge_guild_dungeon_success");

        public static UniTask<string> guild_description_invalid => Localization.Current.Get("common", "guild_description_invalid");

        public static UniTask<string> failed_challenge_guild_dungeon => Localization.Current.Get("common", "failed_challenge_guild_dungeon");

        public static UniTask<string> guild_description_bad_word => Localization.Current.Get("common", "guild_description_bad_word");

        public static UniTask<string> password_failed => Localization.Current.Get("common", "password_failed");

        public static UniTask<string> try_again_few_seconds => Localization.Current.Get("common", "try_again_few_seconds");

        public static UniTask<string> need_input => Localization.Current.Get("common", "need_input");

        public static UniTask<string> insert_least_one_hero => Localization.Current.Get("common", "insert_least_one_hero");

        public static UniTask<string> change_success => Localization.Current.Get("common", "change_success");

        public static UniTask<string> email => Localization.Current.Get("common", "email");

        public static UniTask<string> code_verify => Localization.Current.Get("common", "code_verify");

        public static UniTask<string> master_can_not_quit_guild => Localization.Current.Get("common", "master_can_not_quit_guild");

        public static UniTask<string> sure_leave_guild => Localization.Current.Get("common", "sure_leave_guild");

        public static UniTask<string> have_left_guild => Localization.Current.Get("common", "have_left_guild");

        public static UniTask<string> need_level_mastery => Localization.Current.Get("common", "need_level_mastery");

        public static UniTask<string> login_failed => Localization.Current.Get("common", "login_failed");

        public static UniTask<string> boss_died => Localization.Current.Get("common", "boss_died");

        public static UniTask<string> limit_level_x => Localization.Current.Get("common", "limit_level_x");

        public static UniTask<string> continue_facebook => Localization.Current.Get("common", "continue_facebook");

        public static UniTask<string> remove_friend_success => Localization.Current.Get("common", "remove_friend_success");

        public static UniTask<string> do_want_delete_mail => Localization.Current.Get("common", "do_want_delete_mail");

        public static UniTask<string> can_not_claim_mail => Localization.Current.Get("common", "can_not_claim_mail");

        public static UniTask<string> send_success => Localization.Current.Get("common", "send_success");

        public static UniTask<string> claim_success => Localization.Current.Get("common", "claim_success");

        public static UniTask<string> claim_send_success => Localization.Current.Get("common", "claim_send_success");

        public static UniTask<string> can_not_claim_send => Localization.Current.Get("common", "can_not_claim_send");

        public static UniTask<string> do_want_delete_all => Localization.Current.Get("common", "do_want_delete_all");

        public static UniTask<string> add_friend_success => Localization.Current.Get("common", "add_friend_success");

        public static UniTask<string> hero_in_arena => Localization.Current.Get("common", "hero_in_arena");

        public static UniTask<string> hero_in_training => Localization.Current.Get("common", "hero_in_training");

        public static UniTask<string> require_level_x => Localization.Current.Get("common", "require_level_x");

        public static UniTask<string> help => Localization.Current.Get("common", "help");

        public static UniTask<string> guild_name_contain_banned_word => Localization.Current.Get("common", "guild_name_contain_banned_word");

        public static UniTask<string> guild_desc_contain_banned_word => Localization.Current.Get("common", "guild_desc_contain_banned_word");

        public static UniTask<string> selected => Localization.Current.Get("common", "selected");

        public static UniTask<string> not_enough_x => Localization.Current.Get("common", "not_enough_x");

        public static UniTask<string> casino_shop => Localization.Current.Get("common", "casino_shop");

        public static UniTask<string> altar_shop => Localization.Current.Get("common", "altar_shop");

        public static UniTask<string> guild_shop => Localization.Current.Get("common", "guild_shop");

        public static UniTask<string> arena_shop => Localization.Current.Get("common", "arena_shop");

        public static UniTask<string> want_to_buy => Localization.Current.Get("common", "want_to_buy");

        public static UniTask<string> require_tavern => Localization.Current.Get("common", "require_tavern");

        public static UniTask<string> require_hero_star_x => Localization.Current.Get("common", "require_hero_star_x");

        public static UniTask<string> require_hero_faction_x => Localization.Current.Get("common", "require_hero_faction_x");

        public static UniTask<string> require_hero_class_x => Localization.Current.Get("common", "require_hero_class_x");

        public static UniTask<string> want_to_cancel_quest => Localization.Current.Get("common", "want_to_cancel_quest");

        public static UniTask<string> want_to_speed_up => Localization.Current.Get("common", "want_to_speed_up");

        public static UniTask<string> not_enough_equipment => Localization.Current.Get("common", "not_enough_equipment");

        public static UniTask<string> noti_full_hero => Localization.Current.Get("common", "noti_full_hero");

        public static UniTask<string> unlock_new_function => Localization.Current.Get("common", "unlock_new_function");

        public static UniTask<string> reset => Localization.Current.Get("common", "reset");

        public static UniTask<string> mastery_skill => Localization.Current.Get("common", "mastery_skill");

        public static UniTask<string> need_reset_main_mastery => Localization.Current.Get("common", "need_reset_main_mastery");

        public static UniTask<string> want_to_reset => Localization.Current.Get("common", "want_to_reset");

        public static UniTask<string> not_enough_resource => Localization.Current.Get("common", "not_enough_resource");

        public static UniTask<string> user_profile => Localization.Current.Get("common", "user_profile");

        public static UniTask<string> fanpage => Localization.Current.Get("common", "fanpage");

        public static UniTask<string> go_to_fanpage_notice => Localization.Current.Get("common", "go_to_fanpage_notice");

        public static UniTask<string> want_to_switch_server => Localization.Current.Get("common", "want_to_switch_server");

        public static UniTask<string> want_to_new_server => Localization.Current.Get("common", "want_to_new_server");

        public static UniTask<string> want_to_clear_data => Localization.Current.Get("common", "want_to_clear_data");

        public static UniTask<string> connecting_server => Localization.Current.Get("common", "connecting_server");

        public static UniTask<string> init_service => Localization.Current.Get("common", "init_service");

        public static UniTask<string> init_data_request => Localization.Current.Get("common", "init_data_request");

        public static UniTask<string> init_resource_request => Localization.Current.Get("common", "init_resource_request");

        public static UniTask<string> download_asset_bundle => Localization.Current.Get("common", "download_asset_bundle");

        public static UniTask<string> next_scout => Localization.Current.Get("common", "next_scout");

        public static UniTask<string> summoner_can_view => Localization.Current.Get("common", "summoner_can_view");

        public static UniTask<string> require_stage_x => Localization.Current.Get("common", "require_stage_x");

        public static UniTask<string> hero_info_max_level => Localization.Current.Get("common", "hero_info_max_level");

        public static UniTask<string> daily_quest => Localization.Current.Get("common", "daily_quest");

        public static UniTask<string> hero_level_cap_to => Localization.Current.Get("common", "hero_level_cap_to");

        public static UniTask<string> bonus_class => Localization.Current.Get("common", "bonus_class");

        public static UniTask<string> bonus_faction => Localization.Current.Get("common", "bonus_faction");

        public static UniTask<string> bonus_class_faction => Localization.Current.Get("common", "bonus_class_faction");

        public static UniTask<string> free_gem => Localization.Current.Get("common", "free_gem");

        public static UniTask<string> skill_enhance => Localization.Current.Get("common", "skill_enhance");

        public static UniTask<string> level_cap => Localization.Current.Get("common", "level_cap");

        public static UniTask<string> how_many_purchase => Localization.Current.Get("common", "how_many_purchase");

        public static UniTask<string> sell => Localization.Current.Get("common", "sell");

        public static UniTask<string> vip_full => Localization.Current.Get("common", "vip_full");

        public static UniTask<string> copy_to_clipboard => Localization.Current.Get("common", "copy_to_clipboard");

        public static UniTask<string> player_blocked => Localization.Current.Get("common", "player_blocked");

        public static UniTask<string> hero_fragment_title_star => Localization.Current.Get("common", "hero_fragment_title_star");

        public static UniTask<string> hero_fragment_faction => Localization.Current.Get("common", "hero_fragment_faction");

        public static UniTask<string> hero_fragment_name => Localization.Current.Get("common", "hero_fragment_name");

        public static UniTask<string> hero_fragment_star => Localization.Current.Get("common", "hero_fragment_star");

        public static UniTask<string> hero_fragment_star_faction => Localization.Current.Get("common", "hero_fragment_star_faction");

        public static UniTask<string> hero_fragment_info => Localization.Current.Get("common", "hero_fragment_info");

        public static UniTask<string> artifact_fragment_title_1 => Localization.Current.Get("common", "artifact_fragment_title_1");

        public static UniTask<string> artifact_fragment_title_2 => Localization.Current.Get("common", "artifact_fragment_title_2");

        public static UniTask<string> artifact_fragment_title_3 => Localization.Current.Get("common", "artifact_fragment_title_3");

        public static UniTask<string> artifact_fragment_title_4 => Localization.Current.Get("common", "artifact_fragment_title_4");

        public static UniTask<string> artifact_fragment_title_5 => Localization.Current.Get("common", "artifact_fragment_title_5");

        public static UniTask<string> artifact_fragment_title_6 => Localization.Current.Get("common", "artifact_fragment_title_6");

        public static UniTask<string> artifact_fragment_info => Localization.Current.Get("common", "artifact_fragment_info");

        public static UniTask<string> require_level_stage => Localization.Current.Get("common", "require_level_stage");

        public static UniTask<string> require_vip_or_stage => Localization.Current.Get("common", "require_vip_or_stage");

        public static UniTask<string> require_vip_or_level_stage => Localization.Current.Get("common", "require_vip_or_level_stage");

        public static UniTask<string> achievement => Localization.Current.Get("common", "achievement");

        public static UniTask<string> quest_tree => Localization.Current.Get("common", "quest_tree");

        public static UniTask<string> achievement_tittle_group_1 => Localization.Current.Get("common", "achievement_tittle_group_1");

        public static UniTask<string> achievement_tittle_group_2 => Localization.Current.Get("common", "achievement_tittle_group_2");

        public static UniTask<string> achievement_tittle_group_3 => Localization.Current.Get("common", "achievement_tittle_group_3");

        public static UniTask<string> achievement_tittle_group_4 => Localization.Current.Get("common", "achievement_tittle_group_4");

        public static UniTask<string> achievement_tittle_group_5 => Localization.Current.Get("common", "achievement_tittle_group_5");

        public static UniTask<string> quest_tree_tittle_group_1 => Localization.Current.Get("common", "quest_tree_tittle_group_1");

        public static UniTask<string> quest_tree_tittle_group_2 => Localization.Current.Get("common", "quest_tree_tittle_group_2");

        public static UniTask<string> quest_tree_tittle_group_3 => Localization.Current.Get("common", "quest_tree_tittle_group_3");

        public static UniTask<string> completed => Localization.Current.Get("common", "completed");

        public static UniTask<string> player_already_show_info => Localization.Current.Get("common", "player_already_show_info");

        public static UniTask<string> in_progress => Localization.Current.Get("common", "in_progress");

        public static UniTask<string> new_password_is_last => Localization.Current.Get("common", "new_password_is_last");

        public static UniTask<string> new_password_failed => Localization.Current.Get("common", "new_password_failed");

        public static UniTask<string> chat_delay => Localization.Current.Get("common", "chat_delay");

        public static UniTask<string> search_failed => Localization.Current.Get("common", "search_failed");

        public static UniTask<string> need_input_friend_id => Localization.Current.Get("common", "need_input_friend_id");

        public static UniTask<string> send_failed => Localization.Current.Get("common", "send_failed");

        public static UniTask<string> warning_send_mail => Localization.Current.Get("common", "warning_send_mail");

        public static UniTask<string> mail_content => Localization.Current.Get("common", "mail_content");

        public static UniTask<string> max_hero => Localization.Current.Get("common", "max_hero");

        public static UniTask<string> enough_hero_material => Localization.Current.Get("common", "enough_hero_material");

        public static UniTask<string> max_turn_bought => Localization.Current.Get("common", "max_turn_bought");

        public static UniTask<string> hero_max_star => Localization.Current.Get("common", "hero_max_star");

        public static UniTask<string> need_up_max_level => Localization.Current.Get("common", "need_up_max_level");

        public static UniTask<string> hero_is_training => Localization.Current.Get("common", "hero_is_training");

        public static UniTask<string> hour_x => Localization.Current.Get("common", "hour_x");

        public static UniTask<string> min_x => Localization.Current.Get("common", "min_x");

        public static UniTask<string> smash_reward => Localization.Current.Get("common", "smash_reward");

        public static UniTask<string> refresh_x => Localization.Current.Get("common", "refresh_x");

        public static UniTask<string> potion_1 => Localization.Current.Get("common", "potion_1");

        public static UniTask<string> potion_2 => Localization.Current.Get("common", "potion_2");

        public static UniTask<string> potion_3 => Localization.Current.Get("common", "potion_3");

        public static UniTask<string> full_slot => Localization.Current.Get("common", "full_slot");

        public static UniTask<string> want_to_use_potion => Localization.Current.Get("common", "want_to_use_potion");

        public static UniTask<string> day_ago_format => Localization.Current.Get("common", "day_ago_format");

        public static UniTask<string> hour_ago_format => Localization.Current.Get("common", "hour_ago_format");

        public static UniTask<string> min_ago_format => Localization.Current.Get("common", "min_ago_format");

        public static UniTask<string> second_ago_format => Localization.Current.Get("common", "second_ago_format");

        public static UniTask<string> tower_record_error => Localization.Current.Get("common", "tower_record_error");

        public static UniTask<string> require_vip_or_level => Localization.Current.Get("common", "require_vip_or_level");

        public static UniTask<string> reach_limited_pack => Localization.Current.Get("common", "reach_limited_pack");

        public static UniTask<string> all_heroes_were_killed => Localization.Current.Get("common", "all_heroes_were_killed");

        public static UniTask<string> use_id_format => Localization.Current.Get("common", "use_id_format");

        public static UniTask<string> guild_not_found => Localization.Current.Get("common", "guild_not_found");

        public static UniTask<string> recommend_guild_failed => Localization.Current.Get("common", "recommend_guild_failed");

        public static UniTask<string> have_just_joined_guild => Localization.Current.Get("common", "have_just_joined_guild");

        public static UniTask<string> boss_changed_successful => Localization.Current.Get("common", "boss_changed_successful");

        public static UniTask<string> select_boss_failed => Localization.Current.Get("common", "select_boss_failed");

        public static UniTask<string> challenge_guild_boss_successful => Localization.Current.Get("common", "challenge_guild_boss_successful");

        public static UniTask<string> challenge_guild_boss_failed => Localization.Current.Get("common", "challenge_guild_boss_failed");

        public static UniTask<string> guild_was_kicked => Localization.Current.Get("common", "guild_was_kicked");

        public static UniTask<string> check_in_successful => Localization.Current.Get("common", "check_in_successful");

        public static UniTask<string> restore_failed => Localization.Current.Get("common", "restore_failed");

        public static UniTask<string> play_record_failed => Localization.Current.Get("common", "play_record_failed");

        public static UniTask<string> need_clear_previous_stage => Localization.Current.Get("common", "need_clear_previous_stage");

        public static UniTask<string> map_cleared => Localization.Current.Get("common", "map_cleared");

        public static UniTask<string> no_video => Localization.Current.Get("common", "no_video");

        public static UniTask<string> current_name => Localization.Current.Get("common", "current_name");

        public static UniTask<string> product_not_exist => Localization.Current.Get("common", "product_not_exist");

        public static UniTask<string> purchase_processing => Localization.Current.Get("common", "purchase_processing");

        public static UniTask<string> register_account_success => Localization.Current.Get("common", "register_account_success");

        public static UniTask<string> new_pass_limit => Localization.Current.Get("common", "new_pass_limit");

        public static UniTask<string> new_pass_special => Localization.Current.Get("common", "new_pass_special");

        public static UniTask<string> confirm_pass_fail => Localization.Current.Get("common", "confirm_pass_fail");

        public static UniTask<string> disconnect => Localization.Current.Get("common", "disconnect");

        public static UniTask<string> dungeon_time_up => Localization.Current.Get("common", "dungeon_time_up");

        public static UniTask<string> change_language => Localization.Current.Get("common", "change_language");

        public static UniTask<string> create_guild => Localization.Current.Get("common", "create_guild");

        public static UniTask<string> want_block => Localization.Current.Get("common", "want_block");

        public static UniTask<string> want_unblock => Localization.Current.Get("common", "want_unblock");

        public static UniTask<string> want_delete_all_mail => Localization.Current.Get("common", "want_delete_all_mail");

        public static UniTask<string> want_refresh_tavern => Localization.Current.Get("common", "want_refresh_tavern");

        public static UniTask<string> remove_friend => Localization.Current.Get("common", "remove_friend");

        public static UniTask<string> have_verified_email => Localization.Current.Get("common", "have_verified_email");

        public static UniTask<string> quit_game => Localization.Current.Get("common", "quit_game");

        public static UniTask<string> want_refresh_shop => Localization.Current.Get("common", "want_refresh_shop");

        public static UniTask<string> all_hero_died => Localization.Current.Get("common", "all_hero_died");

        public static UniTask<string> resend => Localization.Current.Get("common", "resend");

        public static UniTask<string> input_code => Localization.Current.Get("common", "input_code");

        public static UniTask<string> noti_code => Localization.Current.Get("common", "noti_code");

        public static UniTask<string> update => Localization.Current.Get("common", "update");

        public static UniTask<string> raw_pack_1 => Localization.Current.Get("common", "raw_pack_1");

        public static UniTask<string> raw_pack_2 => Localization.Current.Get("common", "raw_pack_2");

        public static UniTask<string> raw_pack_3 => Localization.Current.Get("common", "raw_pack_3");

        public static UniTask<string> raw_pack_4 => Localization.Current.Get("common", "raw_pack_4");

        public static UniTask<string> raw_pack_5 => Localization.Current.Get("common", "raw_pack_5");

        public static UniTask<string> limited_pack_1 => Localization.Current.Get("common", "limited_pack_1");

        public static UniTask<string> limited_pack_2 => Localization.Current.Get("common", "limited_pack_2");

        public static UniTask<string> limited_pack_3 => Localization.Current.Get("common", "limited_pack_3");

        public static UniTask<string> limited_pack_4 => Localization.Current.Get("common", "limited_pack_4");

        public static UniTask<string> limited_pack_5 => Localization.Current.Get("common", "limited_pack_5");

        public static UniTask<string> limited_pack_6 => Localization.Current.Get("common", "limited_pack_6");

        public static UniTask<string> limited_pack_7 => Localization.Current.Get("common", "limited_pack_7");

        public static UniTask<string> limited_pack_8 => Localization.Current.Get("common", "limited_pack_8");

        public static UniTask<string> limited_pack_9 => Localization.Current.Get("common", "limited_pack_9");

        public static UniTask<string> limited_pack_10 => Localization.Current.Get("common", "limited_pack_10");

        public static UniTask<string> smash_many => Localization.Current.Get("common", "smash_many");

        public static UniTask<string> events => Localization.Current.Get("common", "events");

        public static UniTask<string> event_summon => Localization.Current.Get("common", "event_summon");

        public static UniTask<string> event_prophet_tree => Localization.Current.Get("common", "event_prophet_tree");

        public static UniTask<string> event_arena => Localization.Current.Get("common", "event_arena");

        public static UniTask<string> event_wheel_of_fate => Localization.Current.Get("common", "event_wheel_of_fate");

        public static UniTask<string> event_tavern => Localization.Current.Get("common", "event_tavern");

        public static UniTask<string> event_collection => Localization.Current.Get("common", "event_collection");

        public static UniTask<string> event_exchange => Localization.Current.Get("common", "event_exchange");

        public static UniTask<string> event_bundle => Localization.Current.Get("common", "event_bundle");

        public static UniTask<string> event_hot_deal => Localization.Current.Get("common", "event_hot_deal");

        public static UniTask<string> event_prophet_tree_info => Localization.Current.Get("common", "event_prophet_tree_info");

        public static UniTask<string> event_wheel_of_fate_info => Localization.Current.Get("common", "event_wheel_of_fate_info");

        public static UniTask<string> event_collection_info => Localization.Current.Get("common", "event_collection_info");

        public static UniTask<string> event_tavern_info => Localization.Current.Get("common", "event_tavern_info");

        public static UniTask<string> event_summon_info => Localization.Current.Get("common", "event_summon_info");

        public static UniTask<string> event_arena_info => Localization.Current.Get("common", "event_arena_info");

        public static UniTask<string> event_bundle_info => Localization.Current.Get("common", "event_bundle_info");

        public static UniTask<string> event_hot_deal_info => Localization.Current.Get("common", "event_hot_deal_info");

        public static UniTask<string> gate => Localization.Current.Get("common", "gate");

        public static UniTask<string> enemy => Localization.Current.Get("common", "enemy");

        public static UniTask<string> faction_restrain => Localization.Current.Get("common", "faction_restrain");

        public static UniTask<string> faction_restrain_info => Localization.Current.Get("common", "faction_restrain_info");

        public static UniTask<string> round => Localization.Current.Get("common", "round");

        public static UniTask<string> invite => Localization.Current.Get("common", "invite");

        public static UniTask<string> name => Localization.Current.Get("common", "name");

        public static UniTask<string> stock => Localization.Current.Get("common", "stock");

        public static UniTask<string> select_guild_logo => Localization.Current.Get("common", "select_guild_logo");

        public static UniTask<string> member => Localization.Current.Get("common", "member");

        public static UniTask<string> master => Localization.Current.Get("common", "master");

        public static UniTask<string> deputy => Localization.Current.Get("common", "deputy");

        public static UniTask<string> guild_notice => Localization.Current.Get("common", "guild_notice");

        public static UniTask<string> season_end_in => Localization.Current.Get("common", "season_end_in");

        public static UniTask<string> stage => Localization.Current.Get("common", "stage");

        public static UniTask<string> hall_of_fame => Localization.Current.Get("common", "hall_of_fame");

        public static UniTask<string> floor => Localization.Current.Get("common", "floor");

        public static UniTask<string> remove_all => Localization.Current.Get("common", "remove_all");

        public static UniTask<string> enemy_team => Localization.Current.Get("common", "enemy_team");

        public static UniTask<string> go => Localization.Current.Get("common", "go");

        public static UniTask<string> save_point => Localization.Current.Get("common", "save_point");

        public static UniTask<string> next_stage => Localization.Current.Get("common", "next_stage");

        public static UniTask<string> attacker => Localization.Current.Get("common", "attacker");

        public static UniTask<string> defender => Localization.Current.Get("common", "defender");

        public static UniTask<string> forge_equipment => Localization.Current.Get("common", "forge_equipment");

        public static UniTask<string> upgrade_hero => Localization.Current.Get("common", "upgrade_hero");

        public static UniTask<string> summon_hero => Localization.Current.Get("common", "summon_hero");

        public static UniTask<string> enter_redemption_code => Localization.Current.Get("common", "enter_redemption_code");

        public static UniTask<string> gift_code => Localization.Current.Get("common", "gift_code");

        public static UniTask<string> current_ranking => Localization.Current.Get("common", "current_ranking");

        public static UniTask<string> monthly_packs => Localization.Current.Get("common", "monthly_packs");

        public static UniTask<string> raw_packs => Localization.Current.Get("common", "raw_packs");

        public static UniTask<string> limited_packs => Localization.Current.Get("common", "limited_packs");

        public static UniTask<string> total_reward => Localization.Current.Get("common", "total_reward");

        public static UniTask<string> instant_reward => Localization.Current.Get("common", "instant_reward");

        public static UniTask<string> weekly => Localization.Current.Get("common", "weekly");

        public static UniTask<string> monthly => Localization.Current.Get("common", "monthly");

        public static UniTask<string> premium_monthly => Localization.Current.Get("common", "premium_monthly");

        public static UniTask<string> free_acquire_video_reward => Localization.Current.Get("common", "free_acquire_video_reward");

        public static UniTask<string> limit_pack_per_week => Localization.Current.Get("common", "limit_pack_per_week");

        public static UniTask<string> limit_pack_per_month => Localization.Current.Get("common", "limit_pack_per_month");

        public static UniTask<string> lock_name => Localization.Current.Get("common", "lock_name");

        public static UniTask<string> edit_lock_heroes => Localization.Current.Get("common", "edit_lock_heroes");

        public static UniTask<string> back_to_current => Localization.Current.Get("common", "back_to_current");

        public static UniTask<string> mastery_name => Localization.Current.Get("common", "mastery_name");

        public static UniTask<string> get_vip_point_to_reach => Localization.Current.Get("common", "get_vip_point_to_reach");

        public static UniTask<string> remove => Localization.Current.Get("common", "remove");

        public static UniTask<string> replace => Localization.Current.Get("common", "replace");

        public static UniTask<string> use => Localization.Current.Get("common", "use");

        public static UniTask<string> add_one => Localization.Current.Get("common", "add_one");

        public static UniTask<string> add_ten => Localization.Current.Get("common", "add_ten");

        public static UniTask<string> admin_mail => Localization.Current.Get("common", "admin_mail");

        public static UniTask<string> moderator_mail => Localization.Current.Get("common", "moderator_mail");

        public static UniTask<string> merchant => Localization.Current.Get("common", "merchant");

        public static UniTask<string> enter_name_please => Localization.Current.Get("common", "enter_name_please");

        public static UniTask<string> enter_chat => Localization.Current.Get("common", "enter_chat");

        public static UniTask<string> chat => Localization.Current.Get("common", "chat");

        public static UniTask<string> join => Localization.Current.Get("common", "join");

        public static UniTask<string> please_wait_for_seconds => Localization.Current.Get("common", "please_wait_for_seconds");

        public static UniTask<string> max => Localization.Current.Get("common", "max");

        public static UniTask<string> gold_mine => Localization.Current.Get("common", "gold_mine");

        public static UniTask<string> friend_not_save_formation => Localization.Current.Get("common", "friend_not_save_formation");

        public static UniTask<string> not_enough_quest_refresh => Localization.Current.Get("common", "not_enough_quest_refresh");

        public static UniTask<string> do_you_want_use_resource => Localization.Current.Get("common", "do_you_want_use_resource");

        public static UniTask<string> wanna_kick_member => Localization.Current.Get("common", "wanna_kick_member");

        public static UniTask<string> special => Localization.Current.Get("common", "special");

        public static UniTask<string> first_purchase => Localization.Current.Get("common", "first_purchase");

        public static UniTask<string> account_limit_character => Localization.Current.Get("common", "account_limit_character");

        public static UniTask<string> hero_food_moon_title => Localization.Current.Get("common", "hero_food_moon_title");

        public static UniTask<string> hero_food_sun_info => Localization.Current.Get("common", "hero_food_sun_info");

        public static UniTask<string> hero_food_sun_title => Localization.Current.Get("common", "hero_food_sun_title");

        public static UniTask<string> hero_food_moon_info => Localization.Current.Get("common", "hero_food_moon_info");

        public static UniTask<string> boss => Localization.Current.Get("common", "boss");

        public static UniTask<string> verify_email_success => Localization.Current.Get("common", "verify_email_success");

        public static UniTask<string> level_up_reward => Localization.Current.Get("common", "level_up_reward");

        public static UniTask<string> no_tavern_quest => Localization.Current.Get("common", "no_tavern_quest");

        public static UniTask<string> season_open_in => Localization.Current.Get("common", "season_open_in");

        public static UniTask<string> cleared => Localization.Current.Get("common", "cleared");

        public static UniTask<string> claim_reach_level => Localization.Current.Get("common", "claim_reach_level");

        public static UniTask<string> more_time_reach_level => Localization.Current.Get("common", "more_time_reach_level");

        public static UniTask<string> claim_to_not_max => Localization.Current.Get("common", "claim_to_not_max");

        public static UniTask<string> to_reach_level_x => Localization.Current.Get("common", "to_reach_level_x");

        public static UniTask<string> ranking_1 => Localization.Current.Get("common", "ranking_1");

        public static UniTask<string> ranking_2 => Localization.Current.Get("common", "ranking_2");

        public static UniTask<string> ranking_3 => Localization.Current.Get("common", "ranking_3");

        public static UniTask<string> ranking_4 => Localization.Current.Get("common", "ranking_4");

        public static UniTask<string> ranking_5 => Localization.Current.Get("common", "ranking_5");

        public static UniTask<string> ranking_6 => Localization.Current.Get("common", "ranking_6");

        public static UniTask<string> ranking_7 => Localization.Current.Get("common", "ranking_7");

        public static UniTask<string> ranking_top_1 => Localization.Current.Get("common", "ranking_top_1");

        public static UniTask<string> ranking_top_2 => Localization.Current.Get("common", "ranking_top_2");

        public static UniTask<string> top_x => Localization.Current.Get("common", "top_x");

        public static UniTask<string> top_x_plus => Localization.Current.Get("common", "top_x_plus");

        public static UniTask<string> top_x_x => Localization.Current.Get("common", "top_x_x");

        public static UniTask<string> point_x_minus => Localization.Current.Get("common", "point_x_minus");

        public static UniTask<string> point_x_plus => Localization.Current.Get("common", "point_x_plus");

        public static UniTask<string> point_x_x => Localization.Current.Get("common", "point_x_x");

        public static UniTask<string> not_ranked => Localization.Current.Get("common", "not_ranked");

        public static UniTask<string> version_outdate => Localization.Current.Get("common", "version_outdate");

        public static UniTask<string> role => Localization.Current.Get("common", "role");

        public static UniTask<string> ago => Localization.Current.Get("common", "ago");

    }

    public static class more
    {
        public static UniTask<string> preload_resources => Localization.Current.Get("more", "preload_resources");

        public static UniTask<string> download_resource_complete => Localization.Current.Get("more", "download_resource_complete");

        public static UniTask<string> load_user_data => Localization.Current.Get("more", "load_user_data");

        public static UniTask<string> start_game => Localization.Current.Get("more", "start_game");

        public static UniTask<string> under_maintenance => Localization.Current.Get("more", "under_maintenance");

        public static UniTask<string> no_data => Localization.Current.Get("more", "no_data");

        public static UniTask<string> change_leader => Localization.Current.Get("more", "change_leader");

        public static UniTask<string> set_as_leader => Localization.Current.Get("more", "set_as_leader");

        public static UniTask<string> guild_member_list => Localization.Current.Get("more", "guild_member_list");

        public static UniTask<string> confirm_change_leader => Localization.Current.Get("more", "confirm_change_leader");

        public static UniTask<string> unblock_training_condition => Localization.Current.Get("more", "unblock_training_condition");

        public static UniTask<string> quick_battle => Localization.Current.Get("more", "quick_battle");

        public static UniTask<string> quick_battle_info => Localization.Current.Get("more", "quick_battle_info");

        public static UniTask<string> monthly_reward => Localization.Current.Get("more", "monthly_reward");

        public static UniTask<string> max_quick_battle_turn => Localization.Current.Get("more", "max_quick_battle_turn");

        public static UniTask<string> event_has_ended => Localization.Current.Get("more", "event_has_ended");

        public static UniTask<string> archived => Localization.Current.Get("more", "archived");

        public static UniTask<string> more_items => Localization.Current.Get("more", "more_items");

        public static UniTask<string> purchase_items => Localization.Current.Get("more", "purchase_items");

        public static UniTask<string> limited_pack_desc_1 => Localization.Current.Get("more", "limited_pack_desc_1");

        public static UniTask<string> limited_pack_desc_2 => Localization.Current.Get("more", "limited_pack_desc_2");

        public static UniTask<string> limited_pack_desc_3 => Localization.Current.Get("more", "limited_pack_desc_3");

        public static UniTask<string> limited_pack_desc_4 => Localization.Current.Get("more", "limited_pack_desc_4");

        public static UniTask<string> limited_pack_desc_5 => Localization.Current.Get("more", "limited_pack_desc_5");

        public static UniTask<string> limited_pack_desc_6 => Localization.Current.Get("more", "limited_pack_desc_6");

        public static UniTask<string> limited_pack_desc_7 => Localization.Current.Get("more", "limited_pack_desc_7");

        public static UniTask<string> limited_pack_desc_8 => Localization.Current.Get("more", "limited_pack_desc_8");

        public static UniTask<string> companion_buff => Localization.Current.Get("more", "companion_buff");

        public static UniTask<string> total => Localization.Current.Get("more", "total");

        public static UniTask<string> when_you_login => Localization.Current.Get("more", "when_you_login");

        public static UniTask<string> claim_each_day => Localization.Current.Get("more", "claim_each_day");

        public static UniTask<string> day => Localization.Current.Get("more", "day");

        public static UniTask<string> speed_up_gold => Localization.Current.Get("more", "speed_up_gold");

        public static UniTask<string> speed_up_hero_exp => Localization.Current.Get("more", "speed_up_hero_exp");

        public static UniTask<string> speed_up_summoner_exp => Localization.Current.Get("more", "speed_up_summoner_exp");

        public static UniTask<string> speed_up_gold_info => Localization.Current.Get("more", "speed_up_gold_info");

        public static UniTask<string> speed_up_hero_exp_info => Localization.Current.Get("more", "speed_up_hero_exp_info");

        public static UniTask<string> speed_up_summoner_exp_info => Localization.Current.Get("more", "speed_up_summoner_exp_info");

        public static UniTask<string> all_received => Localization.Current.Get("more", "all_received");

        public static UniTask<string> attack_success => Localization.Current.Get("more", "attack_success");

        public static UniTask<string> attack_fail => Localization.Current.Get("more", "attack_fail");

        public static UniTask<string> defense_success => Localization.Current.Get("more", "defense_success");

        public static UniTask<string> defense_fail => Localization.Current.Get("more", "defense_fail");

        public static UniTask<string> revenge => Localization.Current.Get("more", "revenge");

        public static UniTask<string> hide => Localization.Current.Get("more", "hide");

        public static UniTask<string> season_end_reward => Localization.Current.Get("more", "season_end_reward");

        public static UniTask<string> champion => Localization.Current.Get("more", "champion");

        public static UniTask<string> reward_area_end => Localization.Current.Get("more", "reward_area_end");

        public static UniTask<string> go_to_mail => Localization.Current.Get("more", "go_to_mail");

        public static UniTask<string> arena_point_reset => Localization.Current.Get("more", "arena_point_reset");

        public static UniTask<string> rate_x => Localization.Current.Get("more", "rate_x");

        public static UniTask<string> season_end => Localization.Current.Get("more", "season_end");

        public static UniTask<string> highest_ever => Localization.Current.Get("more", "highest_ever");

        public static UniTask<string> random_item_pool => Localization.Current.Get("more", "random_item_pool");

        public static UniTask<string> next_refresh => Localization.Current.Get("more", "next_refresh");

        public static UniTask<string> community => Localization.Current.Get("more", "community");

        public static UniTask<string> guild_log_join => Localization.Current.Get("more", "guild_log_join");

        public static UniTask<string> guild_log_leave => Localization.Current.Get("more", "guild_log_leave");

        public static UniTask<string> guild_log_assign_leader => Localization.Current.Get("more", "guild_log_assign_leader");

        public static UniTask<string> guild_log_assign_sub_leader => Localization.Current.Get("more", "guild_log_assign_sub_leader");

        public static UniTask<string> guild_log_kick_out => Localization.Current.Get("more", "guild_log_kick_out");

        public static UniTask<string> free_refresh => Localization.Current.Get("more", "free_refresh");

        public static UniTask<string> flash_sale => Localization.Current.Get("more", "flash_sale");

        public static UniTask<string> rate_title => Localization.Current.Get("more", "rate_title");

        public static UniTask<string> not_rate_contain => Localization.Current.Get("more", "not_rate_contain");

        public static UniTask<string> transaction_mail => Localization.Current.Get("more", "transaction_mail");

        public static UniTask<string> weekly_packs => Localization.Current.Get("more", "weekly_packs");

        public static UniTask<string> subscription_packs => Localization.Current.Get("more", "subscription_packs");

        public static UniTask<string> rate_content => Localization.Current.Get("more", "rate_content");

        public static UniTask<string> rate => Localization.Current.Get("more", "rate");

        public static UniTask<string> not_rate => Localization.Current.Get("more", "not_rate");

        public static UniTask<string> go_to_fanpage => Localization.Current.Get("more", "go_to_fanpage");

        public static UniTask<string> notice_watch_ads => Localization.Current.Get("more", "notice_watch_ads");

        public static UniTask<string> play_video => Localization.Current.Get("more", "play_video");

        public static UniTask<string> init_proceed_failed => Localization.Current.Get("more", "init_proceed_failed");

        public static UniTask<string> start_free_trial => Localization.Current.Get("more", "start_free_trial");

        public static UniTask<string> trial_available => Localization.Current.Get("more", "trial_available");

        public static UniTask<string> warning_flash_sale => Localization.Current.Get("more", "warning_flash_sale");

        public static UniTask<string> warning_download_data => Localization.Current.Get("more", "warning_download_data");

        public static UniTask<string> not_enough_space_memory => Localization.Current.Get("more", "not_enough_space_memory");

        public static UniTask<string> retry => Localization.Current.Get("more", "retry");

        public static UniTask<string> download => Localization.Current.Get("more", "download");

        public static UniTask<string> event_login => Localization.Current.Get("more", "event_login");

        public static UniTask<string> event_login_info => Localization.Current.Get("more", "event_login_info");

        public static UniTask<string> tip_1 => Localization.Current.Get("more", "tip_1");

        public static UniTask<string> tip_2 => Localization.Current.Get("more", "tip_2");

        public static UniTask<string> tip_3 => Localization.Current.Get("more", "tip_3");

        public static UniTask<string> tip_4 => Localization.Current.Get("more", "tip_4");

        public static UniTask<string> tip_5 => Localization.Current.Get("more", "tip_5");

        public static UniTask<string> tip_6 => Localization.Current.Get("more", "tip_6");

        public static UniTask<string> tip_7 => Localization.Current.Get("more", "tip_7");

        public static UniTask<string> notice_upgrade_stone_converting => Localization.Current.Get("more", "notice_upgrade_stone_converting");

        public static UniTask<string> day_only => Localization.Current.Get("more", "day_only");

        public static UniTask<string> login_event_progress => Localization.Current.Get("more", "login_event_progress");

        public static UniTask<string> notice_switch_all_summoner => Localization.Current.Get("more", "notice_switch_all_summoner");

        public static UniTask<string> not_enough_point => Localization.Current.Get("more", "not_enough_point");

        public static UniTask<string> event_arena_ranking => Localization.Current.Get("more", "event_arena_ranking");

        public static UniTask<string> event_arena_ranking_info => Localization.Current.Get("more", "event_arena_ranking_info");

        public static UniTask<string> notice_reset_hero => Localization.Current.Get("more", "notice_reset_hero");

        public static UniTask<string> guild_hall => Localization.Current.Get("more", "guild_hall");

        public static UniTask<string> guild_hall_info => Localization.Current.Get("more", "guild_hall_info");

        public static UniTask<string> join_now => Localization.Current.Get("more", "join_now");

        public static UniTask<string> are_you_sure => Localization.Current.Get("more", "are_you_sure");

        public static UniTask<string> registered_member => Localization.Current.Get("more", "registered_member");

        public static UniTask<string> phase_message_tittle => Localization.Current.Get("more", "phase_message_tittle");

        public static UniTask<string> message_phase_1 => Localization.Current.Get("more", "message_phase_1");

        public static UniTask<string> message_phase_2 => Localization.Current.Get("more", "message_phase_2");

        public static UniTask<string> change_formation => Localization.Current.Get("more", "change_formation");

        public static UniTask<string> change_defender => Localization.Current.Get("more", "change_defender");

        public static UniTask<string> guild_leader_benefit => Localization.Current.Get("more", "guild_leader_benefit");

        public static UniTask<string> notice_evolve_hero_converting => Localization.Current.Get("more", "notice_evolve_hero_converting");

        public static UniTask<string> unlock_previous_stage => Localization.Current.Get("more", "unlock_previous_stage");

        public static UniTask<string> missing_join_stage => Localization.Current.Get("more", "missing_join_stage");

        public static UniTask<string> deal_damage_to_get_reward => Localization.Current.Get("more", "deal_damage_to_get_reward");

        public static UniTask<string> only_leader_can_change_boss => Localization.Current.Get("more", "only_leader_can_change_boss");

        public static UniTask<string> total_damage => Localization.Current.Get("more", "total_damage");

        public static UniTask<string> event_release_festival => Localization.Current.Get("more", "event_release_festival");

        public static UniTask<string> event_release_festival_info => Localization.Current.Get("more", "event_release_festival_info");

        public static UniTask<string> player_join_server => Localization.Current.Get("more", "player_join_server");

        public static UniTask<string> skip_batte => Localization.Current.Get("more", "skip_batte");

        public static UniTask<string> summoner_locked => Localization.Current.Get("more", "summoner_locked");

        public static UniTask<string> member_has_registered => Localization.Current.Get("more", "member_has_registered");

        public static UniTask<string> not_eligible_to_join => Localization.Current.Get("more", "not_eligible_to_join");

        public static UniTask<string> guild_war_phase_1_name => Localization.Current.Get("more", "guild_war_phase_1_name");

        public static UniTask<string> guild_war_phase_2_name => Localization.Current.Get("more", "guild_war_phase_2_name");

        public static UniTask<string> guild_war_phase_3_name => Localization.Current.Get("more", "guild_war_phase_3_name");

        public static UniTask<string> random_boss => Localization.Current.Get("more", "random_boss");

        public static UniTask<string> try_time => Localization.Current.Get("more", "try_time");

        public static UniTask<string> check_out_defenders => Localization.Current.Get("more", "check_out_defenders");

        public static UniTask<string> limited_pack_11 => Localization.Current.Get("more", "limited_pack_11");

        public static UniTask<string> limited_pack_desc_11 => Localization.Current.Get("more", "limited_pack_desc_11");

        public static UniTask<string> event_shop => Localization.Current.Get("more", "event_shop");

        public static UniTask<string> mission => Localization.Current.Get("more", "mission");

        public static UniTask<string> exchange => Localization.Current.Get("more", "exchange");

        public static UniTask<string> not_enough => Localization.Current.Get("more", "not_enough");

        public static UniTask<string> limit_x => Localization.Current.Get("more", "limit_x");

        public static UniTask<string> soul_shop => Localization.Current.Get("more", "soul_shop");

        public static UniTask<string> hidden_deal => Localization.Current.Get("more", "hidden_deal");

        public static UniTask<string> owned => Localization.Current.Get("more", "owned");

        public static UniTask<string> guild_owned => Localization.Current.Get("more", "guild_owned");

        public static UniTask<string> not_in_guild => Localization.Current.Get("more", "not_in_guild");

        public static UniTask<string> new_name => Localization.Current.Get("more", "new_name");

        public static UniTask<string> out_of_turn => Localization.Current.Get("more", "out_of_turn");

        public static UniTask<string> event_exchange_1 => Localization.Current.Get("more", "event_exchange_1");

        public static UniTask<string> event_exchange_1_info => Localization.Current.Get("more", "event_exchange_1_info");

        public static UniTask<string> event_exchange_2 => Localization.Current.Get("more", "event_exchange_2");

        public static UniTask<string> event_exchange_2_info => Localization.Current.Get("more", "event_exchange_2_info");

        public static UniTask<string> event_exchange_3 => Localization.Current.Get("more", "event_exchange_3");

        public static UniTask<string> event_exchange_3_info => Localization.Current.Get("more", "event_exchange_3_info");

        public static UniTask<string> profit => Localization.Current.Get("more", "profit");

        public static UniTask<string> tilion_nick_name => Localization.Current.Get("more", "tilion_nick_name");

        public static UniTask<string> donate => Localization.Current.Get("more", "donate");

        public static UniTask<string> guild_donate_history => Localization.Current.Get("more", "guild_donate_history");

        public static UniTask<string> defronowe_nick_name => Localization.Current.Get("more", "defronowe_nick_name");

        public static UniTask<string> first_time_reward_desc => Localization.Current.Get("more", "first_time_reward_desc");

        public static UniTask<string> first_time_reward => Localization.Current.Get("more", "first_time_reward");

        public static UniTask<string> go_to_shop => Localization.Current.Get("more", "go_to_shop");

        public static UniTask<string> guild_donate_help => Localization.Current.Get("more", "guild_donate_help");

        public static UniTask<string> guild_donate_title => Localization.Current.Get("more", "guild_donate_title");

        public static UniTask<string> starter_pack => Localization.Current.Get("more", "starter_pack");

        public static UniTask<string> owned_x => Localization.Current.Get("more", "owned_x");

        public static UniTask<string> starter_pack_name_1 => Localization.Current.Get("more", "starter_pack_name_1");

        public static UniTask<string> starter_pack_desc_2 => Localization.Current.Get("more", "starter_pack_desc_2");

        public static UniTask<string> starter_pack_desc_3 => Localization.Current.Get("more", "starter_pack_desc_3");

        public static UniTask<string> starter_pack_desc_4 => Localization.Current.Get("more", "starter_pack_desc_4");

        public static UniTask<string> extra => Localization.Current.Get("more", "extra");

        public static UniTask<string> quick_battle_ticket_2_0 => Localization.Current.Get("more", "quick_battle_ticket_2_0");

        public static UniTask<string> quick_battle_ticket_2_10 => Localization.Current.Get("more", "quick_battle_ticket_2_10");

        public static UniTask<string> quick_battle_ticket_8_0 => Localization.Current.Get("more", "quick_battle_ticket_8_0");

        public static UniTask<string> event_type_20 => Localization.Current.Get("more", "event_type_20");

        public static UniTask<string> event_type_20_info => Localization.Current.Get("more", "event_type_20_info");

        public static UniTask<string> hero_lock_in_inventory => Localization.Current.Get("more", "hero_lock_in_inventory");

        public static UniTask<string> hero_in_guild_war => Localization.Current.Get("more", "hero_in_guild_war");

        public static UniTask<string> require_vip => Localization.Current.Get("more", "require_vip");

        public static UniTask<string> received => Localization.Current.Get("more", "received");

        public static UniTask<string> final_reward => Localization.Current.Get("more", "final_reward");

        public static UniTask<string> day_x => Localization.Current.Get("more", "day_x");

        public static UniTask<string> buy_item_quest_name => Localization.Current.Get("more", "buy_item_quest_name");

        public static UniTask<string> event_server_open => Localization.Current.Get("more", "event_server_open");

        public static UniTask<string> item_loot => Localization.Current.Get("more", "item_loot");

        public static UniTask<string> done => Localization.Current.Get("more", "done");

        public static UniTask<string> support => Localization.Current.Get("more", "support");

        public static UniTask<string> check_game_version => Localization.Current.Get("more", "check_game_version");

        public static UniTask<string> check_game_logic => Localization.Current.Get("more", "check_game_logic");

        public static UniTask<string> check_game_resources => Localization.Current.Get("more", "check_game_resources");

        public static UniTask<string> check_resources_config => Localization.Current.Get("more", "check_resources_config");

        public static UniTask<string> go_to_store => Localization.Current.Get("more", "go_to_store");

        public static UniTask<string> switch_all => Localization.Current.Get("more", "switch_all");

        public static UniTask<string> server_open => Localization.Current.Get("more", "server_open");

        public static UniTask<string> login_summoner_era => Localization.Current.Get("more", "login_summoner_era");

        public static UniTask<string> login_facebook => Localization.Current.Get("more", "login_facebook");

        public static UniTask<string> login_google => Localization.Current.Get("more", "login_google");

        public static UniTask<string> login_apple => Localization.Current.Get("more", "login_apple");

        public static UniTask<string> binding_summoner_era => Localization.Current.Get("more", "binding_summoner_era");

        public static UniTask<string> binding_facebook => Localization.Current.Get("more", "binding_facebook");

        public static UniTask<string> binding_google => Localization.Current.Get("more", "binding_google");

        public static UniTask<string> binding_apple => Localization.Current.Get("more", "binding_apple");

        public static UniTask<string> binded => Localization.Current.Get("more", "binded");

        public static UniTask<string> noti_binding => Localization.Current.Get("more", "noti_binding");

        public static UniTask<string> mail_verified => Localization.Current.Get("more", "mail_verified");

        public static UniTask<string> min_donate_event_guild_quest => Localization.Current.Get("more", "min_donate_event_guild_quest");

        public static UniTask<string> player_banned => Localization.Current.Get("more", "player_banned");

        public static UniTask<string> scroll_monthly => Localization.Current.Get("more", "scroll_monthly");

        public static UniTask<string> sale_off => Localization.Current.Get("more", "sale_off");

        public static UniTask<string> hot => Localization.Current.Get("more", "hot");

        public static UniTask<string> level_pass => Localization.Current.Get("more", "level_pass");

        public static UniTask<string> unlock_level_pass => Localization.Current.Get("more", "unlock_level_pass");

        public static UniTask<string> free_reward => Localization.Current.Get("more", "free_reward");

        public static UniTask<string> premium_reward => Localization.Current.Get("more", "premium_reward");

        public static UniTask<string> activated => Localization.Current.Get("more", "activated");

        public static UniTask<string> reward_claimed => Localization.Current.Get("more", "reward_claimed");

        public static UniTask<string> summoner_exp => Localization.Current.Get("more", "summoner_exp");

        public static UniTask<string> tap_to_claim => Localization.Current.Get("more", "tap_to_claim");

        public static UniTask<string> growth_pack_lock => Localization.Current.Get("more", "growth_pack_lock");

        public static UniTask<string> noti_register => Localization.Current.Get("more", "noti_register");

        public static UniTask<string> skip_cut_scene => Localization.Current.Get("more", "skip_cut_scene");

        public static UniTask<string> turn_on_cut_scene => Localization.Current.Get("more", "turn_on_cut_scene");

        public static UniTask<string> select_hero_evolve => Localization.Current.Get("more", "select_hero_evolve");

        public static UniTask<string> noti_confirm_resource => Localization.Current.Get("more", "noti_confirm_resource");

        public static UniTask<string> noti_close_multi_evolve => Localization.Current.Get("more", "noti_close_multi_evolve");

        public static UniTask<string> server_maintain_in_x => Localization.Current.Get("more", "server_maintain_in_x");

        public static UniTask<string> empty_hero_evolve => Localization.Current.Get("more", "empty_hero_evolve");

        public static UniTask<string> multi_evolve => Localization.Current.Get("more", "multi_evolve");

        public static UniTask<string> potion => Localization.Current.Get("more", "potion");

        public static UniTask<string> collection_bag => Localization.Current.Get("more", "collection_bag");

        public static UniTask<string> empty => Localization.Current.Get("more", "empty");

        public static UniTask<string> remaining => Localization.Current.Get("more", "remaining");

        public static UniTask<string> unpack_resources => Localization.Current.Get("more", "unpack_resources");

        public static UniTask<string> choose => Localization.Current.Get("more", "choose");

        public static UniTask<string> hero_alive => Localization.Current.Get("more", "hero_alive");

        public static UniTask<string> hp_full => Localization.Current.Get("more", "hp_full");

        public static UniTask<string> power_full => Localization.Current.Get("more", "power_full");

        public static UniTask<string> guild_war_season_ranking => Localization.Current.Get("more", "guild_war_season_ranking");

        public static UniTask<string> guild_war_member_setup_progress => Localization.Current.Get("more", "guild_war_member_setup_progress");

        public static UniTask<string> guild_war_member_setup_successful => Localization.Current.Get("more", "guild_war_member_setup_successful");

        public static UniTask<string> guild_war_setup_can_be_modified => Localization.Current.Get("more", "guild_war_setup_can_be_modified");

        public static UniTask<string> swap_member_successful => Localization.Current.Get("more", "swap_member_successful");

        public static UniTask<string> ask_for_save_the_change_guild_war_defenders => Localization.Current.Get("more", "ask_for_save_the_change_guild_war_defenders");

        public static UniTask<string> swap_member => Localization.Current.Get("more", "swap_member");

        public static UniTask<string> win => Localization.Current.Get("more", "win");

        public static UniTask<string> your_guild_get => Localization.Current.Get("more", "your_guild_get");

        public static UniTask<string> min_hero_dead_requirement => Localization.Current.Get("more", "min_hero_dead_requirement");

        public static UniTask<string> max_round_requirement => Localization.Current.Get("more", "max_round_requirement");

        public static UniTask<string> save_successful => Localization.Current.Get("more", "save_successful");

        public static UniTask<string> power => Localization.Current.Get("more", "power");

        public static UniTask<string> point_gained => Localization.Current.Get("more", "point_gained");

        public static UniTask<string> not_enough_member_registered => Localization.Current.Get("more", "not_enough_member_registered");

        public static UniTask<string> guild_war_point => Localization.Current.Get("more", "guild_war_point");

        public static UniTask<string> guild_war_season_end => Localization.Current.Get("more", "guild_war_season_end");

        public static UniTask<string> guild_war_register_notification => Localization.Current.Get("more", "guild_war_register_notification");

        public static UniTask<string> require_event_rate_up_point => Localization.Current.Get("more", "require_event_rate_up_point");

        public static UniTask<string> summon_rate_up => Localization.Current.Get("more", "summon_rate_up");

        public static UniTask<string> guaranteed_requirement => Localization.Current.Get("more", "guaranteed_requirement");

        public static UniTask<string> guaranteed_requirement_describe => Localization.Current.Get("more", "guaranteed_requirement_describe");

        public static UniTask<string> summoner_level => Localization.Current.Get("more", "summoner_level");

        public static UniTask<string> daily_packs => Localization.Current.Get("more", "daily_packs");

        public static UniTask<string> name_5_star_hero_reward => Localization.Current.Get("more", "name_5_star_hero_reward");

        public static UniTask<string> clear_stage_to_get_reward => Localization.Current.Get("more", "clear_stage_to_get_reward");

        public static UniTask<string> current_season_reward => Localization.Current.Get("more", "current_season_reward");

        public static UniTask<string> artifact_fragment_title_7 => Localization.Current.Get("more", "artifact_fragment_title_7");

        public static UniTask<string> artifact_fragment_title_8 => Localization.Current.Get("more", "artifact_fragment_title_8");

        public static UniTask<string> artifact_fragment_title_9 => Localization.Current.Get("more", "artifact_fragment_title_9");

        public static UniTask<string> artifact_fragment_title_10 => Localization.Current.Get("more", "artifact_fragment_title_10");

        public static UniTask<string> artifact_fragment_title_11 => Localization.Current.Get("more", "artifact_fragment_title_11");

        public static UniTask<string> artifact_fragment_title_12 => Localization.Current.Get("more", "artifact_fragment_title_12");

        public static UniTask<string> guild_market => Localization.Current.Get("more", "guild_market");

        public static UniTask<string> market_upgrade_describe => Localization.Current.Get("more", "market_upgrade_describe");

        public static UniTask<string> attack_log => Localization.Current.Get("more", "attack_log");

        public static UniTask<string> defense_log => Localization.Current.Get("more", "defense_log");

        public static UniTask<string> attack_count => Localization.Current.Get("more", "attack_count");

        public static UniTask<string> special_offer => Localization.Current.Get("more", "special_offer");

        public static UniTask<string> master_blacksmith => Localization.Current.Get("more", "master_blacksmith");

        public static UniTask<string> your_summoner_name => Localization.Current.Get("more", "your_summoner_name");

        public static UniTask<string> when_upgrade => Localization.Current.Get("more", "when_upgrade");

        public static UniTask<string> material_refund => Localization.Current.Get("more", "material_refund");

        public static UniTask<string> arena_pass => Localization.Current.Get("more", "arena_pass");

        public static UniTask<string> daily_quest_pass => Localization.Current.Get("more", "daily_quest_pass");

        public static UniTask<string> arena_pass_desc => Localization.Current.Get("more", "arena_pass_desc");

        public static UniTask<string> daily_quest_pass_desc => Localization.Current.Get("more", "daily_quest_pass_desc");

        public static UniTask<string> has_not_skin => Localization.Current.Get("more", "has_not_skin");

        public static UniTask<string> select_hero => Localization.Current.Get("more", "select_hero");

        public static UniTask<string> exit_guild => Localization.Current.Get("more", "exit_guild");

        public static UniTask<string> event_golden_time_name => Localization.Current.Get("more", "event_golden_time_name");

        public static UniTask<string> event_golden_time_desc => Localization.Current.Get("more", "event_golden_time_desc");

        public static UniTask<string> event_feed_beast_name => Localization.Current.Get("more", "event_feed_beast_name");

        public static UniTask<string> event_feed_beast_desc => Localization.Current.Get("more", "event_feed_beast_desc");

        public static UniTask<string> event_gem_box_name => Localization.Current.Get("more", "event_gem_box_name");

        public static UniTask<string> event_gem_box_desc => Localization.Current.Get("more", "event_gem_box_desc");

        public static UniTask<string> feed => Localization.Current.Get("more", "feed");

        public static UniTask<string> source_money_type_180 => Localization.Current.Get("more", "source_money_type_180");

        public static UniTask<string> source_money_type_181 => Localization.Current.Get("more", "source_money_type_181");

        public static UniTask<string> select_buff => Localization.Current.Get("more", "select_buff");

        public static UniTask<string> drop_time => Localization.Current.Get("more", "drop_time");

        public static UniTask<string> golden_time_drop_info => Localization.Current.Get("more", "golden_time_drop_info");

        public static UniTask<string> event_midautumn_specialoffer => Localization.Current.Get("more", "event_midautumn_specialoffer");

        public static UniTask<string> event_midautumn_checkin => Localization.Current.Get("more", "event_midautumn_checkin");

        public static UniTask<string> event_midautumn_exchange_name => Localization.Current.Get("more", "event_midautumn_exchange_name");

        public static UniTask<string> event_midautumn_exchange_desc => Localization.Current.Get("more", "event_midautumn_exchange_desc");

        public static UniTask<string> no_limit => Localization.Current.Get("more", "no_limit");

        public static UniTask<string> mid_autumn_offer_1 => Localization.Current.Get("more", "mid_autumn_offer_1");

        public static UniTask<string> mid_autumn_offer_2 => Localization.Current.Get("more", "mid_autumn_offer_2");

        public static UniTask<string> mid_autumn_offer_3 => Localization.Current.Get("more", "mid_autumn_offer_3");

        public static UniTask<string> item_exchange => Localization.Current.Get("more", "item_exchange");

        public static UniTask<string> random_reward => Localization.Current.Get("more", "random_reward");

        public static UniTask<string> not_own_this_skin => Localization.Current.Get("more", "not_own_this_skin");

        public static UniTask<string> arena_pass_unlock_content => Localization.Current.Get("more", "arena_pass_unlock_content");

        public static UniTask<string> daily_quest_pass_unlock_content => Localization.Current.Get("more", "daily_quest_pass_unlock_content");

        public static UniTask<string> popup_context_need_resource => Localization.Current.Get("more", "popup_context_need_resource");

        public static UniTask<string> warning_you_need_more_resources => Localization.Current.Get("more", "warning_you_need_more_resources");

        public static UniTask<string> town_center => Localization.Current.Get("more", "town_center");

        public static UniTask<string> turret => Localization.Current.Get("more", "turret");

        public static UniTask<string> event_golden_time_halloween_name => Localization.Current.Get("more", "event_golden_time_halloween_name");

        public static UniTask<string> event_golden_time_halloween_desc => Localization.Current.Get("more", "event_golden_time_halloween_desc");

        public static UniTask<string> source_money_type_210 => Localization.Current.Get("more", "source_money_type_210");

        public static UniTask<string> source_money_type_211 => Localization.Current.Get("more", "source_money_type_211");

        public static UniTask<string> drop_time_halloween => Localization.Current.Get("more", "drop_time_halloween");

        public static UniTask<string> golden_time_halloween_drop_info => Localization.Current.Get("more", "golden_time_halloween_drop_info");

        public static UniTask<string> dice_title => Localization.Current.Get("more", "dice_title");

        public static UniTask<string> dice_guide => Localization.Current.Get("more", "dice_guide");

        public static UniTask<string> event_halloween_exchange_name => Localization.Current.Get("more", "event_halloween_exchange_name");

        public static UniTask<string> event_halloween_exchange_desc => Localization.Current.Get("more", "event_halloween_exchange_desc");

        public static UniTask<string> halloween_daily_checkin => Localization.Current.Get("more", "halloween_daily_checkin");

        public static UniTask<string> event_halloween_specialoffer => Localization.Current.Get("more", "event_halloween_specialoffer");

        public static UniTask<string> halloween_purchase_1 => Localization.Current.Get("more", "halloween_purchase_1");

        public static UniTask<string> halloween_purchase_2 => Localization.Current.Get("more", "halloween_purchase_2");

        public static UniTask<string> halloween_purchase_3 => Localization.Current.Get("more", "halloween_purchase_3");

        public static UniTask<string> roll => Localization.Current.Get("more", "roll");

        public static UniTask<string> lap_reward => Localization.Current.Get("more", "lap_reward");

        public static UniTask<string> lap_x => Localization.Current.Get("more", "lap_x");

        public static UniTask<string> event_halloween_dice => Localization.Current.Get("more", "event_halloween_dice");

        public static UniTask<string> hallo_ween => Localization.Current.Get("more", "hallo_ween");

        public static UniTask<string> next_free => Localization.Current.Get("more", "next_free");

        public static UniTask<string> lap_completed => Localization.Current.Get("more", "lap_completed");

    }
}