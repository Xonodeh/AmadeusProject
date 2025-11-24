# AmadeusProject
# Project Amadeus (Steins;Gate 0) - C# AI Assistant

![Amadeus Banner](https://img.shields.io/badge/Status-Prototype-green) ![Tech](https://img.shields.io/badge/C%23-WPF-purple) ![AI](https://img.shields.io/badge/AI-Google_Gemini-blue)

> **"This is not just a program. It's her memories."**

Un assistant virtuel de bureau recréant le système **Amadeus** (basé sur le personnage de Kurisu Makise) de l'anime *Steins;Gate 0*. 

Ce projet est une démonstration technique combinant le développement d'interface moderne (**WPF**), l'intelligence artificielle générative (**LLM**) et la synthèse vocale neuronale (**TTS**).

---

## 📸 Aperçu

![Interface Amadeus](docs/demo_screenshot.png)
*(L'interface gère la transparence PNG pour une intégration fluide sur le bureau Windows)*

---

## 🛠️ Stack Technique

Ce projet a été construit pour explorer l'interaction homme-machine via C#.

* **Langage :** C# (.NET 6 / .NET 8)
* **Framework UI :** WPF (Windows Presentation Foundation) pour la gestion avancée des médias et de la transparence.
* **Cerveau (LLM) :** [Google Gemini 1.5 Flash API](https://ai.google.dev/) (via REST).
* **Voix (TTS) :** [ElevenLabs API](https://elevenlabs.io/) (Clonage vocal neuronal).
* **Données :** JSON Parsing (`System.Text.Json`), HTTP Client asynchrone.

---

## 🧠 Fonctionnalités Clés

### 1. Conversation Contextuelle & Persona
L'IA n'est pas un chatbot générique. Elle utilise un **System Prompt** avancé pour :
* Adopter la personnalité "Tsundere" et scientifique de Kurisu Makise.
* Maintenir une mémoire de la conversation (historique de chat).
* Réagir dynamiquement aux propos de l'utilisateur.

### 2. Analyse de Sentiment & Synchronisation Visuelle
Le système analyse la réponse textuelle générée par l'IA pour détecter l'émotion dominante avant même que la voix ne soit générée.
* **Prompt Engineering :** L'IA tague ses réponses (ex: `[ANGRY] Don't call me Christina!`).
* **Parsing C# :** Le backend intercepte ces tags pour mettre à jour le Sprite (Live-switch) instantanément.

### 3. Synthèse Vocale (TTS)
Intégration de l'API ElevenLabs pour générer une voix identique à celle du personnage original, synchronisée avec l'affichage du texte.
