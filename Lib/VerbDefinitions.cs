using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XAPI {
	/// <summary>
	/// Helper class with properties to access premade Verbs.
	/// 
	/// This class / file were built by parsing the JS XAPIWrapper's Verb definitions from GitHub:
	/// https://github.com/adlnet/xAPIWrapper/blob/master/src/verbs.js
	/// </summary>
	public sealed class Verbs {
		public static Verb Abandoned {
			get {
				if (Verbs.abandoned == null) {
					Verbs.abandoned = new Verb("abandoned", "https://w3id.org/xapi/adl/verbs/abandoned");

					Verbs.abandoned.AddDisplayPair("en", "abandoned");
				}

				return Verbs.abandoned;
			}
		}


		public static Verb Answered {
			get {
				if (Verbs.answered == null) {
					Verbs.answered = new Verb("answered", "http://adlnet.gov/expapi/verbs/answered");

					Verbs.answered.AddDisplayPair("de", "beantwortete");
					Verbs.answered.AddDisplayPair("en", "answered");
					Verbs.answered.AddDisplayPair("fr", "a répondu");
					Verbs.answered.AddDisplayPair("es", "contestó");
				}

				return Verbs.answered;
			}
		}


		public static Verb Asked {
			get {
				if (Verbs.asked == null) {
					Verbs.asked = new Verb("asked", "http://adlnet.gov/expapi/verbs/asked");

					Verbs.asked.AddDisplayPair("de", "fragte");
					Verbs.asked.AddDisplayPair("en", "asked");
					Verbs.asked.AddDisplayPair("fr", "a demandé");
					Verbs.asked.AddDisplayPair("es", "preguntó");
				}

				return Verbs.asked;
			}
		}


		public static Verb Attempted {
			get {
				if (Verbs.attempted == null) {
					Verbs.attempted = new Verb("attempted", "http://adlnet.gov/expapi/verbs/attempted");

					Verbs.attempted.AddDisplayPair("de", "versuchte");
					Verbs.attempted.AddDisplayPair("en", "attempted");
					Verbs.attempted.AddDisplayPair("fr", "a essayé");
					Verbs.attempted.AddDisplayPair("es", "intentó");
				}

				return Verbs.attempted;
			}
		}


		public static Verb Attended {
			get {
				if (Verbs.attended == null) {
					Verbs.attended = new Verb("attended", "http://adlnet.gov/expapi/verbs/attended");

					Verbs.attended.AddDisplayPair("de", "nahm teil an");
					Verbs.attended.AddDisplayPair("en", "attended");
					Verbs.attended.AddDisplayPair("fr", "a suivi");
					Verbs.attended.AddDisplayPair("es", "asistió");
				}

				return Verbs.attended;
			}
		}


		public static Verb Commented {
			get {
				if (Verbs.commented == null) {
					Verbs.commented = new Verb("commented", "http://adlnet.gov/expapi/verbs/commented");

					Verbs.commented.AddDisplayPair("de", "kommentierte");
					Verbs.commented.AddDisplayPair("en", "commented");
					Verbs.commented.AddDisplayPair("fr", "a commenté");
					Verbs.commented.AddDisplayPair("es", "comentó");
				}

				return Verbs.commented;
			}
		}


		public static Verb Completed {
			get {
				if (Verbs.completed == null) {
					Verbs.completed = new Verb("completed", "http://adlnet.gov/expapi/verbs/completed");

					Verbs.completed.AddDisplayPair("de", "beendete");
					Verbs.completed.AddDisplayPair("en", "completed");
					Verbs.completed.AddDisplayPair("fr", "a terminé");
					Verbs.completed.AddDisplayPair("es", "completó");
				}

				return Verbs.completed;
			}
		}


		public static Verb Exited {
			get {
				if (Verbs.exited == null) {
					Verbs.exited = new Verb("exited", "http://adlnet.gov/expapi/verbs/exited");

					Verbs.exited.AddDisplayPair("de", "verließ");
					Verbs.exited.AddDisplayPair("en", "exited");
					Verbs.exited.AddDisplayPair("fr", "a quitté");
					Verbs.exited.AddDisplayPair("es", "salió");
				}

				return Verbs.exited;
			}
		}


		public static Verb Experienced {
			get {
				if (Verbs.experienced == null) {
					Verbs.experienced = new Verb("experienced", "http://adlnet.gov/expapi/verbs/experienced");

					Verbs.experienced.AddDisplayPair("de", "erlebte");
					Verbs.experienced.AddDisplayPair("en", "experienced");
					Verbs.experienced.AddDisplayPair("fr", "a éprouvé");
					Verbs.experienced.AddDisplayPair("es", "experimentó");
				}

				return Verbs.experienced;
			}
		}


		public static Verb Failed {
			get {
				if (Verbs.failed == null) {
					Verbs.failed = new Verb("failed", "http://adlnet.gov/expapi/verbs/failed");

					Verbs.failed.AddDisplayPair("de", "verfehlte");
					Verbs.failed.AddDisplayPair("en", "failed");
					Verbs.failed.AddDisplayPair("fr", "a échoué");
					Verbs.failed.AddDisplayPair("es", "fracasó");
				}

				return Verbs.failed;
			}
		}


		public static Verb Imported {
			get {
				if (Verbs.imported == null) {
					Verbs.imported = new Verb("imported", "http://adlnet.gov/expapi/verbs/imported");

					Verbs.imported.AddDisplayPair("de", "importierte");
					Verbs.imported.AddDisplayPair("en", "imported");
					Verbs.imported.AddDisplayPair("fr", "a importé");
					Verbs.imported.AddDisplayPair("es", "importó");
				}

				return Verbs.imported;
			}
		}


		public static Verb Initialized {
			get {
				if (Verbs.initialized == null) {
					Verbs.initialized = new Verb("initialized", "http://adlnet.gov/expapi/verbs/initialized");

					Verbs.initialized.AddDisplayPair("de", "initialisierte");
					Verbs.initialized.AddDisplayPair("en", "initialized");
					Verbs.initialized.AddDisplayPair("fr", "a initialisé");
					Verbs.initialized.AddDisplayPair("es", "inicializó");
				}

				return Verbs.initialized;
			}
		}


		public static Verb Interacted {
			get {
				if (Verbs.interacted == null) {
					Verbs.interacted = new Verb("interacted", "http://adlnet.gov/expapi/verbs/interacted");

					Verbs.interacted.AddDisplayPair("de", "interagierte");
					Verbs.interacted.AddDisplayPair("en", "interacted");
					Verbs.interacted.AddDisplayPair("fr", "a interagi");
					Verbs.interacted.AddDisplayPair("es", "interactuó");
				}

				return Verbs.interacted;
			}
		}


		public static Verb Launched {
			get {
				if (Verbs.launched == null) {
					Verbs.launched = new Verb("launched", "http://adlnet.gov/expapi/verbs/launched");

					Verbs.launched.AddDisplayPair("de", "startete");
					Verbs.launched.AddDisplayPair("en", "launched");
					Verbs.launched.AddDisplayPair("fr", "a lancé");
					Verbs.launched.AddDisplayPair("es", "lanzó");
				}

				return Verbs.launched;
			}
		}


		public static Verb Mastered {
			get {
				if (Verbs.mastered == null) {
					Verbs.mastered = new Verb("mastered", "http://adlnet.gov/expapi/verbs/mastered");

					Verbs.mastered.AddDisplayPair("de", "meisterte");
					Verbs.mastered.AddDisplayPair("en", "mastered");
					Verbs.mastered.AddDisplayPair("fr", "a maîtrisé");
					Verbs.mastered.AddDisplayPair("es", "dominó");
				}

				return Verbs.mastered;
			}
		}


		public static Verb Passed {
			get {
				if (Verbs.passed == null) {
					Verbs.passed = new Verb("passed", "http://adlnet.gov/expapi/verbs/passed");

					Verbs.passed.AddDisplayPair("de", "bestand");
					Verbs.passed.AddDisplayPair("en", "passed");
					Verbs.passed.AddDisplayPair("fr", "a réussi");
					Verbs.passed.AddDisplayPair("es", "aprobó");
				}

				return Verbs.passed;
			}
		}


		public static Verb Preferred {
			get {
				if (Verbs.preferred == null) {
					Verbs.preferred = new Verb("preferred", "http://adlnet.gov/expapi/verbs/preferred");

					Verbs.preferred.AddDisplayPair("de", "bevorzugte");
					Verbs.preferred.AddDisplayPair("en", "preferred");
					Verbs.preferred.AddDisplayPair("fr", "a préféré");
					Verbs.preferred.AddDisplayPair("es", "prefirió");
				}

				return Verbs.preferred;
			}
		}


		public static Verb Progressed {
			get {
				if (Verbs.progressed == null) {
					Verbs.progressed = new Verb("progressed", "http://adlnet.gov/expapi/verbs/progressed");

					Verbs.progressed.AddDisplayPair("de", "machte Fortschritt mit");
					Verbs.progressed.AddDisplayPair("en", "progressed");
					Verbs.progressed.AddDisplayPair("fr", "a progressé");
					Verbs.progressed.AddDisplayPair("es", "progresó");
				}

				return Verbs.progressed;
			}
		}


		public static Verb Registered {
			get {
				if (Verbs.registered == null) {
					Verbs.registered = new Verb("registered", "http://adlnet.gov/expapi/verbs/registered");

					Verbs.registered.AddDisplayPair("de", "registrierte");
					Verbs.registered.AddDisplayPair("en", "registered");
					Verbs.registered.AddDisplayPair("fr", "a enregistré");
					Verbs.registered.AddDisplayPair("es", "registró");
				}

				return Verbs.registered;
			}
		}


		public static Verb Responded {
			get {
				if (Verbs.responded == null) {
					Verbs.responded = new Verb("responded", "http://adlnet.gov/expapi/verbs/responded");

					Verbs.responded.AddDisplayPair("de", "reagierte");
					Verbs.responded.AddDisplayPair("en", "responded");
					Verbs.responded.AddDisplayPair("fr", "a répondu");
					Verbs.responded.AddDisplayPair("es", "respondió");
				}

				return Verbs.responded;
			}
		}


		public static Verb Resumed {
			get {
				if (Verbs.resumed == null) {
					Verbs.resumed = new Verb("resumed", "http://adlnet.gov/expapi/verbs/resumed");

					Verbs.resumed.AddDisplayPair("de", "setzte fort");
					Verbs.resumed.AddDisplayPair("en", "resumed");
					Verbs.resumed.AddDisplayPair("fr", "a repris");
					Verbs.resumed.AddDisplayPair("es", "continuó");
				}

				return Verbs.resumed;
			}
		}


		public static Verb Satisfied {
			get {
				if (Verbs.satisfied == null) {
					Verbs.satisfied = new Verb("satisfied", "https://w3id.org/xapi/adl/verbs/satisfied");

					Verbs.satisfied.AddDisplayPair("en", "satisfied");
				}

				return Verbs.satisfied;
			}
		}


		public static Verb Scored {
			get {
				if (Verbs.scored == null) {
					Verbs.scored = new Verb("scored", "http://adlnet.gov/expapi/verbs/scored");

					Verbs.scored.AddDisplayPair("de", "erreichte");
					Verbs.scored.AddDisplayPair("en", "scored");
					Verbs.scored.AddDisplayPair("fr", "a marqué");
					Verbs.scored.AddDisplayPair("es", "anotó");
				}

				return Verbs.scored;
			}
		}


		public static Verb Shared {
			get {
				if (Verbs.shared == null) {
					Verbs.shared = new Verb("shared", "http://adlnet.gov/expapi/verbs/shared");

					Verbs.shared.AddDisplayPair("de", "teilte");
					Verbs.shared.AddDisplayPair("en", "shared");
					Verbs.shared.AddDisplayPair("fr", "a partagé");
					Verbs.shared.AddDisplayPair("es", "compartió");
				}

				return Verbs.shared;
			}
		}


		public static Verb Suspended {
			get {
				if (Verbs.suspended == null) {
					Verbs.suspended = new Verb("suspended", "http://adlnet.gov/expapi/verbs/suspended");

					Verbs.suspended.AddDisplayPair("de", "pausierte");
					Verbs.suspended.AddDisplayPair("en", "suspended");
					Verbs.suspended.AddDisplayPair("fr", "a suspendu");
					Verbs.suspended.AddDisplayPair("es", "aplazó");
				}

				return Verbs.suspended;
			}
		}


		public static Verb Terminated {
			get {
				if (Verbs.terminated == null) {
					Verbs.terminated = new Verb("terminated", "http://adlnet.gov/expapi/verbs/terminated");

					Verbs.terminated.AddDisplayPair("de", "beendete");
					Verbs.terminated.AddDisplayPair("en", "terminated");
					Verbs.terminated.AddDisplayPair("fr", "a terminé");
					Verbs.terminated.AddDisplayPair("es", "terminó");
				}

				return Verbs.terminated;
			}
		}


		public static Verb Waived {
			get {
				if (Verbs.waived == null) {
					Verbs.waived = new Verb("waived", "https://w3id.org/xapi/adl/verbs/waived");

					Verbs.waived.AddDisplayPair("en", "waived");
				}

				return Verbs.waived;
			}
		}

		// Private Fields
		private static Verb abandoned;
		private static Verb answered;
		private static Verb asked;
		private static Verb attempted;
		private static Verb attended;
		private static Verb commented;
		private static Verb completed;
		private static Verb exited;
		private static Verb experienced;
		private static Verb failed;
		private static Verb imported;
		private static Verb initialized;
		private static Verb interacted;
		private static Verb launched;
		private static Verb mastered;
		private static Verb passed;
		private static Verb preferred;
		private static Verb progressed;
		private static Verb registered;
		private static Verb responded;
		private static Verb resumed;
		private static Verb satisfied;
		private static Verb scored;
		private static Verb shared;
		private static Verb suspended;
		private static Verb terminated;
		private static Verb waived;
	}

	/// <summary>
	/// Collection of Special verbs with unique properties when used in a statement.
	/// </summary>
	public static class VerbsSpecial {
		/// <summary>
		/// Gets the verb "Voided".
		/// 
		/// This is a special verb that MUST be used to Void another statement. That other statement
		/// MUST be the object of the statement whose Verb is Voided, using the StatementRef Object Type.
		/// </summary>
		/// <value>The voided.</value>
		public static Verb Voided {
			get {
				if (VerbsSpecial.voided == null) {
					VerbsSpecial.voided = new Verb("voided", "http://adlnet.gov/expapi/verbs/voided");

					VerbsSpecial.voided.AddDisplayPair("de", "entwertete");
					VerbsSpecial.voided.AddDisplayPair("en", "voided");
					VerbsSpecial.voided.AddDisplayPair("fr", "a annulé");
					VerbsSpecial.voided.AddDisplayPair("es", "anuló");
				}

				return VerbsSpecial.voided;
			}
		}

		private static Verb voided;
	}
}
