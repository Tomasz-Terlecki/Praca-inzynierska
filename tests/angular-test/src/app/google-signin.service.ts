import { Injectable } from '@angular/core';
import { Observable, ReplaySubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GoogleSigninService {

  private subject: ReplaySubject<gapi.auth2.GoogleUser> = new ReplaySubject<gapi.auth2.GoogleUser>(1);
  private auth2: gapi.auth2.GoogleAuth;

  constructor() { 
    gapi.load('auth2', () => {
      // gapi.client.init({
      //   clientId: '572032635173-6ec73j4omim2de7vjfviq663q70chbg5.apps.googleusercontent.com',
      //   scope: 'tomasz.terlecki99@gmail.com'
      // });
      gapi.auth2.init({
        client_id: '572032635173-6ec73j4omim2de7vjfviq663q70chbg5.apps.googleusercontent.com'
      })
    })
  }

  public signIn() {
    this.auth2.signIn({
      // scope
    }).then(user => {
      this.subject.next(user);
    }).catch(() => {
      this.subject.next(null);
    })
  }

  public signOut() {
    this.auth2.signOut()
      .then(() => {
        this.subject.next(null);
      })
      .catch(() => {
        // TODO
      })
  }

  public observable() : Observable<gapi.auth2.GoogleUser> {
    return this.subject.asObservable()
  }
}
